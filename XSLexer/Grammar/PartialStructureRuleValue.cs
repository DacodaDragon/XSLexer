namespace XSLexer
{
    /// <summary>
    /// Editable version of StructureRule used through parsing
    /// </summary>
    class PartialStructureRuleValue
    {
        public PartialStructureRuleValue()
        {

        }

        public PartialStructureRuleValue Next { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public string SplitByType { get; set; }
        public bool IsRoot { get; set; }
        public bool IsReference { get; set; }
        public bool IsMultiple { get; set; }
        public bool HasValue { get; set; }

        public StructureRuleValue Finalize()
        {
            return new StructureRuleValue(
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
