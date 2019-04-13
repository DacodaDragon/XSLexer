using System.Collections.Generic;
using XSLexer.Data;
using System.Text;
using System;

namespace XSLexer.Lexing
{
    // This should probably be state machined somehow if we want more
    class Tokenizer
    {
        private DataSet m_Previous = new DataSet("previous");
        private DataSet m_Current = new DataSet("current");

        private List<Token> m_Tokens = new List<Token>(1 << 19);
        private StringBuilder m_Buffer = new StringBuilder(32);

        private string m_Code = "";
        private int m_Index = 0;
        private int m_Line = 1;

        private string m_SearchFlag = "";
        private bool m_SearchInclusive = false;

        private LexConfig m_Config;

        public Tokenizer(LexConfig data)
        {
            m_Config = data;
        }

        public void Reset()
        {
            ClearBuffers();
            m_Tokens.Clear();
            m_Code = "";
            m_Index = 0;
        }

        public TokenSet Tokenize(string code)
        {
            m_Code = code + "\n";
            while (CreateNextToken(out Token token))
            {
                m_Tokens.Add(token);

                if (!string.IsNullOrEmpty(m_SearchFlag))
                    m_Tokens.Add(FindNextTokenOf(m_SearchFlag, token));

            }

            TokenSet Set = new TokenSet(m_Tokens.ToArray());

            Reset();
            return Set;
        }

        public bool CreateNextToken(out Token token, string type = null)
        {
            token = null;
            m_Current = m_Config.Tokens.All;
            for (; m_Index < m_Code.Length; m_Index++)
            {
                if (m_Code[m_Index] == '\n')
                    if (++m_Line % 1000 == 0)
                        Debug.Log(m_Line);


                m_Buffer.Append(m_Code[m_Index]);

                m_Current = GetAvailableTokens(m_Buffer.ToString());

                if (m_Current.Length == 0 && m_Previous.Length == 0)
                {
                    SkipUnknownChar();
                }
                else if (m_Current.Length == 0 && m_Previous.Length > 0)
                {
                    token = CreateToken();
                    return true;
                }
                else if (m_Current.Length > 0 && m_Previous.Length > 0)
                {
                    if (!Overlaps())
                    {
                        token = CreateToken();
                        return true;
                    }
                }

                m_Previous = m_Current;
            }
            return false;
        }

        private void SkipUnknownChar()
        {
            m_Buffer.Remove(m_Buffer.Length - 1, 1);
        }

        private Token FindNextTokenOf(string searchType, Token lastToken)
        {
            string lastType = lastToken.Type;
            string lastValue = lastToken.Value;
            m_Tokens.RemoveAt(m_Tokens.Count - 1);
            int startline = m_Line;
            int startIndex = m_Index - lastValue.Length;

            bool Reading = false;

            DataContainer searchData = m_Config.Tokens.All.GetSet(searchType);
            for (; m_Index < m_Code.Length; m_Index++)
            {
                if (m_Code[m_Index] == '\n')
                    if (++m_Line % 1000 == 0)
                        Debug.Log(m_Line);

                m_Buffer.Append(m_Code[m_Index]);

                bool HasPotential = TokenValidationPredicates.Potential(searchData, m_Buffer.ToString());
                if (HasPotential)
                {
                    Reading = true;
                    continue;
                }
                else if (Reading)
                {
                    m_Buffer.Remove(m_Buffer.Length - 1, 1);

                    bool isFinal = TokenValidationPredicates.Final(searchData, m_Buffer.ToString());

                    if (isFinal)
                    {
                        int length = m_Index - startIndex;
                        m_SearchFlag = "";
                        m_Buffer.Clear();
                        return new Token(lastType, m_Code.Substring(startIndex, length), m_Line);
                    }

                    m_Buffer.Clear();
                    Reading = false;
                }
                else if (!HasPotential)
                {
                    m_Buffer.Clear();
                }
            }

            throw new Exception("Tried parsing until I couldn't");
        }

        private bool Overlaps()
        {
            for (int j = 0; j < m_Current.Length; j++)
            {
                if (!m_Previous.GetSet(m_Current.GetSet(j).Name).IsEmpty)
                    return true;
            }

            return false;
        }

        private void ClearBuffers()
        {
            m_Previous = new DataSet("previous");
            m_Current = new DataSet("current");
            m_Buffer.Clear();
        }

        private Token CreateToken()
        {
            m_Buffer.Remove(m_Buffer.Length - 1, 1);
            DataSet Final = GetFinalTokens(m_Buffer.ToString());

            if (Final.Length > 1)
                throw new Exception("Found ambigious first phase tokens! ");

            if (Final.Length == 0)
                throw new Exception("Tried saving token with no previous containers!");

            Token token = new Token(Final[0].Name, m_Buffer.ToString(), m_Line);

            if (string.IsNullOrEmpty(m_SearchFlag))
            {
                if (Final[0].HasKey(TokenConsts.KEYWORD_UNTIL))
                {
                    m_SearchFlag = Final[0].GetValue(TokenConsts.KEYWORD_UNTIL).value;
                    m_SearchInclusive = false;
                }
            }

            if (string.IsNullOrEmpty(m_SearchFlag))
            {
                if (Final[0].HasKey(TokenConsts.KEYWORD_UNTILWITH))
                {
                    m_SearchFlag = Final[0].GetValue(TokenConsts.KEYWORD_UNTILWITH).value;
                    m_SearchInclusive = true;
                }
            }

            // Clear buffering
            ClearBuffers();

            return token;
        }

        private DataSet GetAvailableTokens(string checkString)
        {
            if (string.IsNullOrEmpty(checkString))
                return new DataSet("");

            return m_Current.Filter((x) => TokenValidationPredicates.Potential(x, checkString));
        }

        private DataSet GetFinalTokens(string checkString)
        {
            if (string.IsNullOrEmpty(checkString))
                return new DataSet("");

            return m_Previous.Filter((x) => TokenValidationPredicates.Final(x, checkString));
        }
    }
}
