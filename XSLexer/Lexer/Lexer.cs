using XSLexer.Data;

namespace XSLexer.Lexer
{
    class LexData
    {
        private TokenDataSet m_TokenConfiguration;
        private DataSet[] m_WordDefinitions;

        public TokenDataSet Tokens => m_TokenConfiguration;
        public DataSet[] WordDefinitions => m_WordDefinitions;


        public LexData(DataSet[] tokenDataSets, DataSet[] WordDefinitions)
        {
            m_TokenConfiguration = new TokenDataSet(tokenDataSets);
            m_WordDefinitions = WordDefinitions;
        }
    }
}
