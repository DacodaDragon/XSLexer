using System.Collections.Generic;

namespace XSLexer.Grammar
{
    class GrammarRuleSetFinalizer
    {
        private GrammarRuleset m_Ruleset;

        public GrammarRuleset Finalize(PartialGrammarRuleset ruleset)
        {
            m_Ruleset = ruleset.Finalize();
            return ResolveAllReferences(m_Ruleset);
        }

        private GrammarRuleset ResolveAllReferences(GrammarRuleset ruleSet)
        {
            foreach (var item in ruleSet.Rules)
            {
                ResolveReferencesForRule(item);
            }

            return ruleSet;
        }

        private void ResolveReferencesForRule(GrammarRule rule)
        {
            GrammarRuleValue value = rule.GrammarRuleValue;
            if (value == null)
                return;

            do
            {
                if (value.IsReference)
                    ResolveReferencesForValue(value);
            }
            while ((value = value.Next) != null);
        }

        private void ResolveReferencesForValue(GrammarRuleValue value)
        {
            value.SetReferences(GetReferencesByType(value.Type));
        }

        private GrammarRule[] GetReferencesByType(string type)
        {
            List<GrammarRule> references = new List<GrammarRule>();
            foreach (var item in m_Ruleset.Rules)
            {
                if (item.Name == type)
                    references.Add(item);
            }
            return references.ToArray();
        }
    }
}
