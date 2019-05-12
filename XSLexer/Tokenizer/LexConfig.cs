using XSLexer.Data;

namespace XSLexer.Lexing
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

        public LexConfig(DataSet tokenDataSets, DataSet WordDefinitions)
        {
            Tokens = new TokenDataSet(tokenDataSets);
            this.WordDefinitions = new WordListDataSet(WordDefinitions);
        }
    }
}
