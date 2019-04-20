using System.Collections.Generic;

namespace XSLexer
{
    /// <summary>
    /// Parses StructureRule tree
    /// </summary>
    static class GrammarRulesetParser
    {
        private static int m_Line = 0;

        public static PartialGrammarRuleset Parse(string code)
        {
            string[] lines = code.Split('\n');
            PartialGrammarRuleset partialGrammarConfiguration = new PartialGrammarRuleset();
            for (int i = 0; i < lines.Length; i++)
            {
                m_Line++;
                if (string.IsNullOrWhiteSpace(lines[i]) || lines[i][0] == '#')
                    continue;
                partialGrammarConfiguration.Add(ParseRule(lines[i]));
            }
            return partialGrammarConfiguration;
        }

        // *************************** RULE PARSING *************************** 
        private static PartialBaseStructureRule ParseRule(string line)
        {
            string[] Struct = line.Split('=');
            PartialBaseStructureRule baseRule = new PartialBaseStructureRule();

            if (Struct[0][0] == '>')
            {
                baseRule.IsRoot = true;
                baseRule.Name = Struct[0].Remove(0, 1).Trim(' ', '\t');
            }
            else
            {
                baseRule.Name = Struct[0].Trim(' ', '\t');
            }

            baseRule.StructureRuleValue = ParseValues(Struct[1]);
            baseRule.Line = m_Line;
            return baseRule;
        }



        // *************************** VALUE PARSING *************************** 
        private static PartialStructureRuleValue ParseValues(string line)
        {
            return ParseValues(line.Split(':'));
        }

        private static PartialStructureRuleValue ParseValues(string[] values)
        {
            PartialStructureRuleValue root;
            PartialStructureRuleValue newest;

            newest = ParseValue(values[0].Trim(' ', '\t'));
            root = newest;

            for (int i = 1; i < values.Length; i++)
            {
                newest.Next = ParseValue(values[i].Trim(' ', '\t'));
                newest = newest.Next;
            }
            return root;
        }

        private static PartialStructureRuleValue ParseValue(string value)
        {
            return ParseValue(new PartialStructureRuleValue(), value);
        }

        private static PartialStructureRuleValue ParseValue(PartialStructureRuleValue rule, string value)
        {
            if (value[0] == '*')
            {
                rule.IsMultiple = true;
                return ParseValue(rule, value.Remove(0, 1));
            }

            if (value[0] == '!')
            {
                rule.IsReference = true;
                return ParseValue(rule, value.Remove(0, 1));
            }

            string[] split = value.Split('&');
            if (split.Length == 2)
            {
                rule.Type = split[0];
                rule.Value = split[1];
                rule.HasValue = true;
                return rule;
            }

            rule.Type = value;
            return rule;
        }
    }
}
