using System.Collections.Generic;

namespace XSLexer
{
    /// <summary>
    /// Ruleset for structure parsing
    /// </summary>
    class StructureRuleValue
    {
        public StructureRuleValue(StructureRuleValue next, string type, string value, string splitByType, bool isReference, bool isMultiple, bool hasValue)
        {
            Next = next;
            Type = type;
            Value = value;
            SplitByType = splitByType;
            IsReference = isReference;
            IsMultiple = isMultiple;
            HasValue = hasValue;
        }

        public StructureRuleValue Next { get; }
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

    class PartialBaseStructureRule
    {
        public PartialBaseStructureRule()
        {
        }

        public int Line { get; set; }
        public bool IsRoot { get; set; }
        public string Name { get; set; }
        public PartialStructureRuleValue StructureRuleValue { get; set; }

        public override string ToString()
        {
            string str = Name;
            if (StructureRuleValue != null)
                str += ": " + StructureRuleValue.ToString();
            return str;
        }
    }

    class PartialGrammarRuleset
    {
        List<PartialBaseStructureRule> RootRules = new List<PartialBaseStructureRule>();
        List<PartialBaseStructureRule> AllRules = new List<PartialBaseStructureRule>();

        public void Add(PartialBaseStructureRule Rule)
        {
            AllRules.Add(Rule);
            if (Rule.IsRoot)
                RootRules.Add(Rule);
        }

        public override string ToString()
        {
            string str = "PartialGrammarRuleset:\n";
            for (int i = 0; i < AllRules.Count; i++)
            {
                str +=  AllRules[i].ToString() + '\n';
            }
            return str;
        }
    }
}
