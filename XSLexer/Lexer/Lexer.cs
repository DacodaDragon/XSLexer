using System.Collections.Generic;
using XSLexer.Data;
using System.Text;
using System;


namespace XSLexer.Lexer
{
    class Tokenizer
    {
        private LexConfig m_Config;
        public Tokenizer(LexConfig data)
        {
            m_Config = data;
        }

        // TODO: Statemachine this
        public Token[] Tokenize(string code)
        {
            DataContainer[] previousContainers = new DataContainer[0];
            List<Token> tokens = new List<Token>();
            StringBuilder buffer = new StringBuilder(32);

            for (int i = 0; i < code.Length; i++)
            {
                buffer.Append(code[i]);

                DataContainer[] containers = FindPossibleFutureTokens(buffer.ToString());

                if (containers.Length == 0 && previousContainers.Length == 0)
                {
                    buffer.Remove(buffer.Length - 1, 1);
                }
                else if (containers.Length == 0 && previousContainers.Length > 0)
                {
                    tokens.Add(CreateToken(buffer));
                    containers = new DataContainer[0];
                    buffer.Clear();
                    i--;
                }
                else if (containers.Length > 0 && previousContainers.Length > 0)
                {
                    DataSet current = new DataSet("CurrentSet", containers);
                    DataSet previous = new DataSet("PreviousSet", previousContainers);

                    int overlap = 0;

                    for (int j = 0; j < current.Length; j++)
                    {
                        if (!previous.GetSet(current.GetSet(j).Name).IsEmpty)
                            overlap++;
                    }

                    if (overlap == 0)
                    {
                        tokens.Add(CreateToken(buffer));
                        containers = new DataContainer[0];
                        buffer.Clear();
                        i--;
                    }
                }

                previousContainers = containers;
            }

            return tokens.ToArray();
        }

        private Token CreateToken(StringBuilder buffer)
        {
            buffer.Remove(buffer.Length - 1, 1);
            DataContainer[] Final = FindPossibleFinalTokens(buffer.ToString());

            if (Final.Length > 1)
            {
                throw new Exception("Found ambigious first phase tokens! ");
            }

            if (Final.Length == 0)
                throw new Exception("Tried saving token with no previous containers!");

            return new Token(Final[0].Name, buffer.ToString());
        }

        private DataContainer[] FindPossibleFutureTokens(string checkString)
        {
            if (string.IsNullOrEmpty(checkString))
                return new DataContainer[0];
            return m_Config.Tokens.Filter((x)=> TokenValidationPredicates.PotentialTokenfilter(x, checkString));
        }

        private DataContainer[] FindPossibleFinalTokens(string checkString)
        {
            if (string.IsNullOrEmpty(checkString))
                return new DataContainer[0];
            return m_Config.Tokens.Filter((x) => TokenValidationPredicates.Final(x, checkString));
        }
    }
}
