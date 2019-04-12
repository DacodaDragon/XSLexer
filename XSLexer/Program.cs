using XSLexer.Properties;
using XSLexer.Lexer;
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

            Token[] tokens = new Tokenizer(config).Tokenize(Resources.XsFunction);

            Debug.Log("Tokens found: " + tokens.Length);
            for (int i = 0; i < tokens.Length; i++)
            {
                Debug.Log($"Tok[{i}]: \t" + tokens[i].Type + "\t== " + tokens[i].Value);
            }

            Debug.Pause();
        }
    }
}
