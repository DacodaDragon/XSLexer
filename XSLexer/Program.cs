using XSLexer.Properties;

namespace XSLexer
{
    class Program
    {
        static void Main(string[] args)
        {
            StructureRulesetParser.Parse(Resources.XsGrammarConfig);
            Debug.Pause();
        }
    }
}
