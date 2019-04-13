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

            Debug.Log("Tokens found: " + tokenSet.Length);
            //Debug.Log(tokenSet);

            Debug.Pause();
        }
    }
}
