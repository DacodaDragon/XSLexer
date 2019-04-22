using System.Collections.Generic;

namespace XSLexer
{
    class PartialGrammarRuleset
    {
        List<PartialBaseGrammarRule> m_AllRules = new List<PartialBaseGrammarRule>();

        public void Add(PartialBaseGrammarRule Rule)
        {
            m_AllRules.Add(Rule);
        }

        public override string ToString()
        {
            string str = "PartialGrammarRuleset:\n";
            for (int i = 0; i < m_AllRules.Count; i++)
            {
                str +=  m_AllRules[i].ToString() + '\n';
            }
            return str;
        }

        public GrammarRuleset Finalize()
        {
            BaseGrammarRule[] rules = new BaseGrammarRule[m_AllRules.Count];
            List<BaseGrammarRule> roots = new List<BaseGrammarRule>();
            for (int i = 0; i < m_AllRules.Count; i++)
            {
                rules[i] = m_AllRules[i].Finalize();
                if (rules[i].IsRoot)
                    roots.Add(rules[i]);
            }
            return new GrammarRuleset(rules, roots.ToArray());
        }
    }
}
