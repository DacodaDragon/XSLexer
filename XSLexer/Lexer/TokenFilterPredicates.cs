using System.Collections.Generic;
using XSLexer.Data;
using System.Text.RegularExpressions;

namespace XSLexer.Lexer
{
    static class TokenValidationPredicates
    {


        public static bool Potential(DataContainer x, string input)
        {
            if (x.HasKey(TokenConsts.KEYWORD_WORD))
            {
                string word = x.GetValue(TokenConsts.KEYWORD_WORD).value;

                // if checkstring is longer than our 'word' it can't be this token
                if (input.Length > word.Length)
                    return false;


                string wordSubstring = word.Substring(0, input.Length);

                if (wordSubstring != word)
                    return false;
            }

            if (x.HasKey(TokenConsts.KEYWORD_LENGTH))
            {
                int length = ParseInt(x, TokenConsts.KEYWORD_LENGTH);
                if (input.Length > length)
                    return false;
            }

            if (!RequirementRegexCheck(x, new string(input[0], 1), TokenConsts.KEYWORD_CHARSTART))
                return false;

            if (input.Length > 1 && !RequirementRecursiveRegexCheck(x, input.Substring(1), TokenConsts.KEYWORD_CHARBODY))
                return false;

            return true;
        }

        public static bool Final(DataContainer x, string input)
        {
            if (x.HasKey(TokenConsts.KEYWORD_WORD))
            {
                string word = x.GetValue(TokenConsts.KEYWORD_WORD).value;

                // if checkstring is longer than our 'word' it can't be this token
                if (input.Length != word.Length)
                    return false;

                if (word != input)
                    return false;
            }

            if (x.HasKey(TokenConsts.KEYWORD_LENGTH))
            {
                int length = ParseInt(x, TokenConsts.KEYWORD_LENGTH);
                if (length != input.Length)
                    return false;
            }

            if (!RequirementRegexCheck(x, new string(input[0], 1), TokenConsts.KEYWORD_CHARSTART))
                return false;

            if (input.Length > 1)
            {
                if (!RequirementRecursiveRegexCheck(x, input.Substring(1), TokenConsts.KEYWORD_CHARBODY))
                    return false;
            }

            return true;
        }

        private static int ParseInt(DataContainer dataContainer, string Keyword)
        {
            if (!int.TryParse(dataContainer.GetValue(TokenConsts.KEYWORD_LENGTH).value, out int length))
            {
                throw new System.Exception($"Tried parsing int from token key {Keyword} in {dataContainer.Name} but failed");
            }
            return length;
        }

        private static bool RequirementRecursiveRegexCheck(DataContainer container, string input, string key)
        {
            List<bool> checks = new List<bool>();
            if (!container.HasKey(key))
                return true; // If we don't have the key it's not a requirement.

            for (int i = 0; i < input.Length; i++)
            {
                checks.Add(RequirementRegexCheck(container, new string(input[i], 1), key));
            }

            return checks.TrueForAll(x => x);
        }

        private static bool RequirementRegexCheck(DataContainer container, string input, string key)
        {
            if (!container.HasKey(key))
                return true; // If we don't have the key it's not a requirement.

            return Regex.IsMatch(input, container.GetValue(key).value);
        }
    }
}
