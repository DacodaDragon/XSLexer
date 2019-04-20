using System.Collections.Generic;

namespace XSLexer
{
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
