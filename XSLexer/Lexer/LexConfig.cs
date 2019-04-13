using XSLexer.Data;


namespace XSLexer.Lexer
{
    class LexConfig
    {
        public TokenDataSet Tokens { get; }

        public LexConfig(DataSet[] tokenDataSets)
        {
            Tokens = new TokenDataSet(tokenDataSets);
        }
    }
}
