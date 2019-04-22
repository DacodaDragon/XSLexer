namespace XSLexer
{
    /// <summary>
    /// Ruleset for structure parsing
    /// </summary>
    class GrammarRuleValue
    {
        public GrammarRuleValue(GrammarRuleValue next, string type, string value, string splitByType, bool isReference, bool isMultiple, bool hasValue)
        {
            Next = next;
            Type = type;
            Value = value;
            SplitByType = splitByType;
            IsReference = isReference;
            IsMultiple = isMultiple;
            HasValue = hasValue;
        }

        public GrammarRuleValue Next { get; }
        public string Type { get; }
        public string Value { get; }
        public string SplitByType { get; }
        public bool IsRoot { get; }
        public bool IsReference { get; }
        public bool IsMultiple { get; }
        public bool HasValue { get; }

        public override string ToString()
        {
            string s = Type;
            if (Next != null)
                s += ' ' + Next.ToString();
            return s;
        }
    }
}
