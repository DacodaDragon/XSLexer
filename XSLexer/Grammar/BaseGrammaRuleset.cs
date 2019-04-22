namespace XSLexer
{
    class BaseGrammarRule
    {
        public BaseGrammarRule(
            int line,
            bool isRoot,
            string name,
            GrammarRuleValue grammarRuleValue)
        {
            Line = line;
            IsRoot = isRoot;
            Name = name;
            GrammarRuleValue = grammarRuleValue;
        }

        public int Line { get; }
        public bool IsRoot { get; }
        public string Name { get; }
        public GrammarRuleValue GrammarRuleValue { get; }

        public override string ToString()
        {
            string str = Name;
            if (GrammarRuleValue != null)
                str += ": " + GrammarRuleValue.ToString();
            return str;
        }
    }
}
