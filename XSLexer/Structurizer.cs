using XSLexer.Lexing;
using XSLexer.Data;
using System.Collections.Generic;
using System.Linq;

namespace XSLexer
{
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

                // If this structure continues until another structure is found
                // continue parsing children until the until value is met
                if (potentials[0].HasKey(TokenConsts.KEYWORD_UNTIL, out DataValue until))
                {
                    StructureToken structure;
                    do // EBIL
                    {
                        structure = ParseNext(Followups);
                        structureToken.Childs.Add(structure);

                    } while (structure.StructType != until.value);

                    // Return when we met the child ender
                    return structureToken;
                }

                // Add the next token, leave
                structureToken.Childs.Add(ParseNext(Followups));
                return structureToken;
            }


            // We can't be sure what we are, so we are going
            // to parse the next token first.
            StructureToken nextToken = ParseNext(GetFollowUps(potentials));

            // When this token is parsed, check what I could have been with
            // the type the next tokend became. 
            DataSet set = RequirementsFilter(nextToken, potentials);

            // If we have only one thing we could have been at this point, hurray!
            // we know what we are. 
            if (set.Length == 1)
            {
                StructureToken structureToken = new StructureToken(token);
                structureToken.StructType = set[0].Name;
                structureToken.Childs.Add(nextToken);

                // If this structure continues until another structure is found
                // continue parsing children until the until value is met
                if (set[0].HasKey(TokenConsts.KEYWORD_UNTIL, out DataValue until))
                {
                    StructureToken structure;
                    do // EBIL
                    {
                        structure = ParseNext(set);
                        structureToken.Childs.Add(structure);

                    } while (structure.StructType != until.value);

                    // Return when we met the child ender
                    return structureToken;
                }
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

        private DataSet RequirementsFilter(StructureToken structureToken, DataSet Followups)
        {
            return Followups.Filter((x) => {
                if (x.HasKey(StructureConsts.KEYWORD_FOLLOWEDBY, out DataValue followups))
                    if (followups.value != structureToken.StructType)
                        return false;
                return true;
            });
        }

        private bool CheckToken(DataSet set, Token token, out DataSet potentials)
        {
            System.Func<DataContainer, bool> predicate = (x) =>
            {
                if (x.HasKey(StructureConsts.KEYWORD_TYPE, out DataValue typeValue) && typeValue.value != token.Type)
                    return false;
                if (x.HasKey(StructureConsts.KEYWORD_VALUE, out DataValue valueValue) && valueValue.value != token.Value)
                    return false;
                return true;
            };

            potentials = set.Filter(predicate);
            return potentials.Length > 0;
        }
    }
}
