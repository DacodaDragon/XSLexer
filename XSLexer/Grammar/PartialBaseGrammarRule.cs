namespace XSLexer
{
    class PartialBaseGrammarRule
    {
        public PartialBaseGrammarRule()
        {

        }

        public int Line { get; set; }
        public bool IsRoot { get; set; }
        public string Name { get; set; }
        public PartialGrammarRuleValue GrammarRuleValue { get; set; }

        public override string ToString()
        {
            string str = Name;
            if (GrammarRuleValue != null)
                str += ": " + GrammarRuleValue.ToString();
            return str;
        }
    }
}
