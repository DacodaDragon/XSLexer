using XSLexer.Properties;
using XSLexer.Grammar;
using XSLexer.Lexing;
using XSLexer.Data;

namespace XSLexer
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet KeywordWordDefinitions = DataSetParser.Parse("WordDefinitions", Resources.DataTypes);
            DataSet TokenDefinitions = DataSetParser.Parse("TokenDefinitions", Resources.TokenDefinitions);
            LexConfig lexConfig = new LexConfig(TokenDefinitions, KeywordWordDefinitions);

            GrammarRuleset GrammarRuleset = GrammarRulesetParser.Parse(Resources.XsGrammarConfig);

            string code = Resources.XsFunction; 

            Lexer lexer = new Lexer(lexConfig);
            GrammarParser grammarParser = new GrammarParser(GrammarRuleset);

            grammarParser.Parse(lexer.Lex(code));

            Debug.Pause();
        }
    }
}
