namespace XSLexer.Grammar
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
        public bool IsReferenceType { get; set; }
        public bool IsMultiple { get; set; }
        public bool HasValue { get; set; }

        public GrammarRuleValue Finalize()
        {
            GrammarRuleValue next = Next != null ? Next.Finalize() : null;

            return new GrammarRuleValue(
                next,
                Type,
                Value,
                SplitByType,
                IsReferenceType,
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
