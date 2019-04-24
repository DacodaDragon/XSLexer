using XSLexer.Properties;
using XSLexer.Grammar;

namespace XSLexer
{
    class Program
    {
        static void Main(string[] args)
        {
            GrammarRuleset ruleset = GrammarRulesetParser.Parse(Resources.XsGrammarConfig);
            Debug.Pause();
        }
    }
}
