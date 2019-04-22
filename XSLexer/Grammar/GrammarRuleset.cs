namespace XSLexer
{
    class GrammarRuleset
    {
        public BaseGrammarRule[] Rules { get; }
        public BaseGrammarRule[] Roots { get; }

        public GrammarRuleset(BaseGrammarRule[] rules, BaseGrammarRule[] roots)
        {
            this.Rules = rules;
            this.Roots = roots;
        }

        public override string ToString()
        {
            string str = "PartialGrammarRuleset:\n";

            foreach (BaseGrammarRule item in Rules)
            {
                str += item.ToString() + '\n';
            }

            return str;
        }
    }
}
