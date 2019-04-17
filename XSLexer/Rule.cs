namespace XSLexer
{
    /// <summary>
    /// Ruleset for structure parsing
    /// </summary>
    class StructureRule
    {
        public StructureRule(StructureRule next, string type, string value, string splitByType, bool isReference, bool isMultiple, bool hasValue)
        {
            Next = next;
            Type = type;
            Value = value;
            SplitByType = splitByType;
            IsReference = isReference;
            IsMultiple = isMultiple;
            HasValue = hasValue;
        }

        public StructureRule Next { get; }
        public string Type { get; }
        public string Value { get; }
        public string SplitByType { get; }
        public bool IsRoot { get; }
        public bool IsReference { get; }
        public bool IsMultiple { get; }
        public bool HasValue { get; }
    }

    /// <summary>
    /// Editable version of StructureRule used through parsing
    /// </summary>
    class PartialStructureRule
    {
        public PartialStructureRule()
        {
        }

        public StructureRule Next { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public string SplitByType { get; set; }
        public bool IsRoot { get; set; }
        public bool IsReference { get; set; }
        public bool IsMultiple { get; set; }
        public bool HasValue { get; set; }

        public StructureRule Finalize()
        {
            return new StructureRule(
                Next,
                Type,
                Value,
                SplitByType,
                IsReference,
                IsMultiple,
                HasValue
            );
        }
    }
}
