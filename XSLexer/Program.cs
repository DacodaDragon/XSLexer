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

            DataSet root = new DataSet("Root Tokens", data.Tokens.Filter(x => true));

            Debug.Log(root);
            Debug.Pause();
            
        }
    }
}
