using XSLexer.Properties;

namespace XSLexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.Log(GrammarRulesetParser.Parse(Resources.XsGrammarConfig));
            Debug.Pause();
        }
    }
}
