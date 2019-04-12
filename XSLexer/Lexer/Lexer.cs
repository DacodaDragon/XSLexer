using System.Collections.Generic;
using XSLexer.Data;
using System.Text;
using System;

namespace XSLexer.Lexer
{
    // This should probably be state machined somehow if we want more
    class Tokenizer
    {
        private DataContainer[] m_Previous = new DataContainer[0];
        private DataContainer[] m_Current = new DataContainer[0];

        private List<Token> m_Tokens = new List<Token>();
        private StringBuilder m_Buffer = new StringBuilder(32);

        private string m_Code = "";
        private int m_Index = 0;

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

        public Token[] Tokenize(string code)
        {
            m_Code = code;
            while (CreateNextToken(out Token token))
                m_Tokens.Add(token);

            Token[] TokenArray = m_Tokens.ToArray();

            Reset();
            return TokenArray;
        }

        public bool CreateNextToken(out Token token)
        {
            token = null;
            for (;m_Index < m_Code.Length; m_Index++)
            {
                m_Buffer.Append(m_Code[m_Index]);

                m_Current = GetAvailableTokens(m_Buffer.ToString(), false);
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

        public void SkipUnknownChar()
        {
            m_Buffer.Remove(m_Buffer.Length - 1, 1);
        }

        private bool Overlaps()
        {
            DataSet current = new DataSet("CurrentSet", m_Current);
            DataSet previous = new DataSet("PreviousSet", m_Previous);

            for (int j = 0; j < current.Length; j++)
            {
                if (!previous.GetSet(current.GetSet(j).Name).IsEmpty)
                    return true;
            }

            return false;
        }

        private void ClearBuffers()
        {
            m_Previous = new DataContainer[0];
            m_Current = new DataContainer[0];
            m_Buffer.Clear();
        }

        private Token CreateToken()
        {
            m_Buffer.Remove(m_Buffer.Length - 1, 1);
            DataContainer[] Final = GetAvailableTokens(m_Buffer.ToString(), true);

            if (Final.Length > 1)
                throw new Exception("Found ambigious first phase tokens! ");

            if (Final.Length == 0)
                throw new Exception("Tried saving token with no previous containers!");

            Token token = new Token(Final[0].Name, m_Buffer.ToString());

            // Clear buffering
            ClearBuffers();

            return token;
        }

        private DataContainer[] GetAvailableTokens(string checkString, bool final)
        {
            if (string.IsNullOrEmpty(checkString))
                return new DataContainer[0];

            Func<DataContainer, bool> TokensPotential = (x) => TokenValidationPredicates.Potential(x, checkString);
            Func<DataContainer, bool> TokensFinal = (x) => TokenValidationPredicates.Final(x, checkString);

            return m_Config.Tokens.Filter(final ? TokensFinal : TokensPotential);
        }
    }
}
