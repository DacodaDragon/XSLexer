using System.Collections.Generic;

namespace XSLexer
{
    /// <summary>
    /// Parses StructureRule tree
    /// </summary>
    static class StructureRulesetParser
    {
        public static void Parse(string code)
        {
            string[] lines = code.Split('\n');

            for (int i = 0; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]) || lines[i][0] == '#')
                    continue;

                Debug.Log(lines[i]);
            }
        }

        public static void Parse()
        {

        }
    }
}
