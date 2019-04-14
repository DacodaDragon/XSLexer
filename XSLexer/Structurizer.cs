using XSLexer.Lexing;
using XSLexer.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace XSLexer
{
    class StructureToken : Token
    {
        public string StructType { get; set; }
        public StructureToken Parent { get; set; }
        public List<StructureToken> Childs { get; } = new List<StructureToken>();

        public StructureToken(Token baseToken) : base(baseToken.Type, baseToken.Value, baseToken.LineNumber)
        {

        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(StructType).Append(":").Append(Value).Append('\n');
            for (int i = 0; i < Childs.Count; i++)
            {
                stringBuilder.Append(Childs[i].ToString(2)).Append('\n');
            }
            return stringBuilder.ToString();
        }

        private object ToString(int v)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(' ', v).Append(StructType).Append(":").Append(Value).Append('\n');
            for (int i = 0; i < Childs.Count; i++)
            {
                stringBuilder.Append(Childs[i].ToString(v+2)).Append('\n');
            }
            return stringBuilder.ToString();
        }
    }

    class Structurizer
    {
        private StructureConfig m_Config { get; set; }
        private TokenSet m_TokenSet;
        private int m_Index = 0;

        private void Reset()
        {
            m_Index = 0;
        }

        public Structurizer(StructureConfig Config)
        {
            m_Config = Config;
        }

        public StructureToken[] Parse(TokenSet set)
        {
            m_TokenSet = set.FilterOut("Spac", "NewL");
            List<StructureToken> Tokens = new List<StructureToken>();
            while (m_Index != m_TokenSet.Length)
                Tokens.Add(ParseRoot());

            return Tokens.ToArray();
        }

        private StructureToken ParseRoot()
        {
            return ParseNext(m_Config.Root);
        }

        private StructureToken ParseNext(DataSet allowedTokens)
        {
            Token token = m_TokenSet[m_Index++];

            if (!CheckToken(allowedTokens, token, out DataSet potentials))
                throw new System.Exception("I can't be anything.. T-T");

            if (potentials.Length == 1)
            {
                // There is only one potential thing this token could be
                // so we know exactly what we are without parsing the
                // follow up tokens
                StructureToken structureToken = new StructureToken(token);
                structureToken.StructType = potentials[0].Name;

                // How many types are there that are supposed to follow me?
                DataSet Followups = GetFollowUps(potentials);

                // If there is nothing that should follow me,
                // then its the end of this tree structure
                if (Followups.Length == 0)
                    return structureToken;

                // If there is something that should follow me
                // parse the next one and add it to my childs
                // TODO: Should support until functionality right here. 
                structureToken.Childs.Add(ParseNext(Followups));
                return structureToken;
            }


            // We can't be sure what we are, so we are going
            // to parse the next token first.
            StructureToken nextToken = ParseNext(GetFollowUps(potentials));

            // When this token is parsed, check what I could have been with
            // the type the next tokend became. 
            DataSet set = potentials.Filter(x => x.Name == nextToken.Type);

            // If we have only one thing we could have been at this point, hurray!
            // we know what we are. 
            if (set.Length == 0)
            {
                StructureToken structureToken = new StructureToken(token);
                structureToken.Type = set[0].Name;
                structureToken.Childs.Add(nextToken);

                // TODO: check if there are remaining children to be parsed

                return structureToken;
            }

            throw new System.Exception("Parsed next token and I atill have no idea what I am T-T");
        }

        private DataSet GetFollowUps(DataSet dataSet)
        {
            return ResolveFollowUpTypes(GetFollowUpTypes(dataSet));
        }

        private string[] GetFollowUpTypes(DataSet dataSet)
        {
            List<string> types = new List<string>();

            for (int i = 0; i < dataSet.Length; i++)
            {
                if (!dataSet[i].HasKey(StructureConsts.KEYWORD_FOLLOWEDBY,
                    out DataValue FollowedBy))
                    continue;

                string[] FollowUps = FollowedBy.value.Split('|');

                for (int j = 0; j < FollowUps.Length; j++)
                {
                    if (!types.Contains(FollowUps[j]))
                        types.Add(FollowUps[j]);
                }
            };

            return types.ToArray();
        }

        private DataSet ResolveFollowUpTypes(string[] types)
        {
            return m_Config.StructureSet.Filter((x) =>
            {
                return types.Contains(x.Name);
            });
        }

        private bool CheckToken(DataSet set, Token token, out DataSet potentials)
        {
            List<DataContainer> container = new List<DataContainer>();
            System.Func<DataContainer, bool> predicate = (x) =>
            {
                if (x.HasKey(StructureConsts.KEYWORD_TYPE, out DataValue typeValue) && typeValue.value != token.Type)
                    return false;
                if (x.HasKey(StructureConsts.KEYWORD_VALUE, out DataValue valueValue) && valueValue.value != token.Value)
                    return false;

                container.Add(x);
                return true;
            };

            potentials = set.Filter(predicate);
            return potentials.Length > 0;
        }
    }
}
