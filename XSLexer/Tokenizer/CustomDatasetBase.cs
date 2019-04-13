using XSLexer.Data;

namespace XSLexer.Lexing
{
    class CustomDatasetBase
    {
        protected DataSet[] m_DataSets;

        public CustomDatasetBase(DataSet[] dataSets)
        {
            m_DataSets = dataSets;
        }
    }
}
