using XSLexer.Data;

namespace XSLexer.Lexing
{
    class TokenReplacer
    {
        private readonly LexConfig lexConfig;

        public TokenReplacer(LexConfig lexConfig)
        {
            this.lexConfig = lexConfig;
        }

        public TokenSet Process(TokenSet set)
        {
            DataContainer[] wordDef = lexConfig.WordDefinitions.All;
            for (int i = 0; i < wordDef.Length; i++)
            {
                Token[] tokens = set.GetAllOfType(wordDef[i].Name);
                for (int j = 0; j < tokens.Length; j++)
                {
                    for (int k = 0; k < wordDef[i].Length; k++)
                    {
                        if (tokens[j].Value == wordDef[i][k].key)
                        {
                            tokens[j].Type = wordDef[i][k].value;
                        }
                    }
                }
            }
            set.Refresh();
            return set;
        }
    }
}
