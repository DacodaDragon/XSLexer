using System.Collections.Generic;

namespace XSLexer.Lexer
{
    class TokenSet
    {
        private Token[] m_Tokens;
        private Dictionary<int, List<Token>> m_Dictionary = new Dictionary<int, List<Token>>(1 << 19);

        public Token this[long i] => m_Tokens[i];
        public long Length => m_Tokens.LongLength;


        public Token[] GetAllOfType(string Type)
        {
            if (m_Dictionary.TryGetValue(Type.GetHashCode(), out List<Token> list))
            {
                return list.ToArray();
            }
            throw new System.Exception($"TokenSet does not contain any tokens of type \"{Type}\"");
        }

        private void AddToDict(Token token)
        {
            int hash = token.Type.GetHashCode();
            if (m_Dictionary.TryGetValue(hash, out List<Token> list))
            {
                list.Add(token);
            }
            else
            {
                List<Token> newList = new List<Token>();
                newList.Add(token);
                m_Dictionary.Add(hash, newList);
            }
        }

        private void RemoveFromDict(Token token)
        {
            int hash = token.Type.GetHashCode();
            if (m_Dictionary.TryGetValue(hash, out List<Token> list))
            {
                list.Remove(token);
            }
            else
            {
                throw new System.Exception("Tried removing a token, but there is no list");
            }
        }

        public TokenSet(Token[] tokens)
        {
            m_Tokens = tokens;
            Refresh();
        }

        public void Refresh()
        {
            m_Dictionary.Clear();
            for (long i = 0; i < m_Tokens.LongLength; i++)
            {
                AddToDict(m_Tokens[i]);
            }
        }
    }
}
