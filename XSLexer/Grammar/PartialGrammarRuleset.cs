using System.Collections.Generic;

namespace XSLexer
{
    class PartialGrammarRuleset
    {
        List<PartialBaseGrammarRule> m_AllRules = new List<PartialBaseGrammarRule>();

        PartialBaseGrammarRule[] GetAllRules => m_AllRules.ToArray();

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
    }
}
