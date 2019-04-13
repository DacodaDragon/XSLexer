using XSLexer.Properties;
using XSLexer.Lexing;
using XSLexer.Data;

namespace XSLexer
{
    class Program
    {
        static void Main(string[] args)
        {
            LexConfig config = new LexConfig(
                new DataSet[] { DataSetParser.Parse("TokensDefinitions", Resources.TokenDefinitions) },
                new DataSet[] { DataSetParser.Parse("DataType Words", Resources.DataTypes) });

            TokenSet tokenSet = new Lexer(config).Lex(Resources.XsFunction);

            Debug.Log("STATS:");
            Debug.Log($"Contains {tokenSet.Length} tokens!");
            for (int i = 0; i < config.Tokens.All.Length; i++)
            {
                if (tokenSet.GetAllOfType(config.Tokens.All.GetSet(i).Name, out TokenSet set))
                {
                    Debug.Log($"Contains type [{config.Tokens.All.GetSet(i).Name}] {set.Length} times!");
                }
            }


            Debug.Log("Tokens found: " + tokenSet.Length);
            //Debug.Log(tokenSet);

            Debug.Pause();
        }
    }
}
