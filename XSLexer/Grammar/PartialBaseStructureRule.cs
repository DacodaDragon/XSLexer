namespace XSLexer
{
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
}
