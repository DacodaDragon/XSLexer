namespace XSLexer
{
    /// <summary>
    /// Editable version of StructureRule used through parsing
    /// </summary>
    class PartialGrammarRuleValue
    {
        public PartialGrammarRuleValue()
        {

        }

        public PartialGrammarRuleValue Next { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public string SplitByType { get; set; }
        public bool IsRoot { get; set; }
        public bool IsReference { get; set; }
        public bool IsMultiple { get; set; }
        public bool HasValue { get; set; }

        public GrammarRuleValue Finalize()
        {
            return new GrammarRuleValue(
                Next?.Finalize(),
                Type,
                Value,
                SplitByType,
                IsReference,
                IsMultiple,
                HasValue
            );
        }

        public override string ToString()
        {
            string s = Type;
            if (Next != null)
                s += ' ' + Next.ToString();
            return s;
        }
    }
}
