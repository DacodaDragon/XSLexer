using XSLexer.Data;

namespace XSLexer.Lexer
{
    class LexConfig
    {
        public TokenDataSet Tokens { get; }
        public WordListDataSet WordDefinitions { get; }

        public LexConfig(DataSet[] tokenDataSets, DataSet[] WordDefinitions)
        {
            Tokens = new TokenDataSet(tokenDataSets);
            this.WordDefinitions = new WordListDataSet(WordDefinitions);
        }
    }
}
