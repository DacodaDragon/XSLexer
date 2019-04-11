using System.Collections.Generic;
using System.Collections;
using XSLexer.Data;

namespace XSLexer.Lexer
{
    class WordListDataSet : CustomDatasetBase
    {
        private DataContainer[] m_Lists;

        public DataContainer[] All => m_Lists;

        public WordListDataSet(DataSet[] dataSets) : base(dataSets)
        {
            m_Lists = FindAllLists();
        }

        private DataContainer[] FindAllLists()
        {
            List<DataContainer> lists = new List<DataContainer>();
            for (int i = 0; i < m_DataSets.Length; i++)
            {
                for (int j = 0; j < m_DataSets[i].Length; j++)
                {
                    lists.Add(m_DataSets[i][j]);
                }
            }
            return lists.ToArray();
        }
    }
}
