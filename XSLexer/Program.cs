using XSLexer.Properties;
using XSLexer.Lexer;
using XSLexer.Data;
using System.Diagnostics;

namespace XSLexer
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch watch = Stopwatch.StartNew();
            LexConfig config = new LexConfig(new DataSet[] { DataSetParser.Parse("TokensDefinitions", Resources.TokenDefinitions) });
            watch.Stop();
            Debug.Log($"Parsed for {watch.ElapsedMilliseconds}ms");

            watch.Restart();
            Token[] tokens = new Tokenizer(config).Tokenize(Resources.XsFunction);
            watch.Stop();
            Debug.Log($"Parsed for {watch.ElapsedMilliseconds}ms");

            Debug.Log("Tokens found: " + tokens.Length);
            //for (int i = 0; i < tokens.Length; i++)
            //{
            //    Debug.Log($"Tok[{i}]: \t" + tokens[i].Type + "\t== " + tokens[i].Value);
            //}

            Debug.Pause();
        }
    }
}
