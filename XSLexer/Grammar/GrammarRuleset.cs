namespace XSLexer
{
    class GrammarRuleset
    {
        public GrammarRule[] Rules { get; }
        public GrammarRule[] Roots { get; }

        public GrammarRuleset(GrammarRule[] rules, GrammarRule[] roots)
        {
            this.Rules = rules;
            this.Roots = roots;
        }

        public override string ToString()
        {
            string str = "GrammarRuleset:\n";

            foreach (GrammarRule item in Rules)
            {
                str += item.ToString() + '\n';
            }

            return str;
        }
    }
}
