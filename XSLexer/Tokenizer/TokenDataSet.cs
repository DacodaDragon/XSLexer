using System.Collections.Generic;
using XSLexer.Data;

namespace XSLexer.Lexing
{
    class TokenDataSet : CustomDatasetBase
    {
        public DataSet Root { get; }
        public DataSet All { get; }

        public DataSet Filter(System.Func<DataContainer, bool> Predicate)
        {
            List<DataContainer> filter = new List<DataContainer>();

            for (int i = 0; i < All.Length; i++)
            {
                if (Predicate.Invoke(All[i]))
                {
                    filter.Add(All[i]);
                }
            }

            return new DataSet("filtered", filter.ToArray());
        }

        private DataSet FindAllTokens()
        {
            List<DataContainer> tokens = new List<DataContainer>();
            for (int i = 0; i < m_DataSets.Length; i++)
            {
                for (int j = 0; j < m_DataSets[i].Length; j++)
                {
                    tokens.Add(m_DataSets[i][j]);
                }
            }
            return new DataSet("all", tokens.ToArray());
        }

        public TokenDataSet(DataSet[] dataSets) : base(dataSets)
        {
            All = FindAllTokens();
            Root = Filter(x => !x.IsEmpty && x.GetValue(TokenConsts.KEYWORD_ROOT).value == TokenConsts.BOOL_TRUE);
        }
    }
}
