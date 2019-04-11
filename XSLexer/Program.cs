using System;
using XSLexer.Properties;
using XSLexer.Lexer;
using XSLexer.Data;

namespace XSLexer
{
    class Program
    {
        static void Main(string[] args)
        {
            LexData data = new LexData(
                new DataSet[] { DataSetParser.Parse("TokensDefinitions", Resources.TokenDefinitions) },
                new DataSet[] { DataSetParser.Parse("DataType Words", Resources.DataTypes) });

            DataSet tokens = new DataSet("Token Definitions", data.Tokens.All);
            DataSet words = new DataSet("Word Definitions", data.WordDefinitions.All);

            Debug.Log(tokens);
            Debug.Log(words);

            Debug.Pause();
        }
    }
}
