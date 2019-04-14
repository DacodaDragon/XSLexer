using XSLexer.Properties;
using XSLexer.Lexing;
using XSLexer.Data;
using System.IO;
using System.Text;
namespace XSLexer
{
    class Program
    {
        static void Main(string[] args)
        {
            LexConfig config = new LexConfig(
                new DataSet[] { DataSetParser.Parse("TokensDefinitions", Resources.TokenDefinitions) },
                new DataSet[] { DataSetParser.Parse("DataType Words", Resources.DataTypes) });
            StructureConfig structureConfig = new StructureConfig(DataSetParser.Parse("Structure Configuration", Resources.XsGrammarConfig));

            TokenSet tokenSet = new Lexer(config, structureConfig).Lex(Resources.XsFunction);

            Debug.Imp("STATS:");
            Debug.Imp($"Contains {tokenSet.Length} tokens!");
            for (int i = 0; i < config.Tokens.All.Length; i++)
            {
                if (tokenSet.GetAllOfType(config.Tokens.All.GetSet(i).Name, out TokenSet set))
                {
                    Debug.Imp($"Contains type [{config.Tokens.All.GetSet(i).Name}] {set.Length} times!");
                }
            }


            Debug.Log("Tokens found: " + tokenSet.Length);
            //Debug.Log(tokenSet);

            StringBuilder sb = new StringBuilder(Resources.XsFunction.Length);
            for (int i = 0; i < tokenSet.Length; i++)
            {
                sb.Append(tokenSet[i].Value);
            }
            File.WriteAllText("D:/Temp/Ree.txt", sb.ToString());
            Debug.Pause();
        }
    }
}
