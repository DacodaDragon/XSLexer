using XSLexer.Lexing;

namespace XSLexer.Grammar
{
    class GrammarParser
    {
        private GrammarRuleset m_GrammarRuleset;
        private TokenSet m_Tokens;
        private int m_Index = 0;

        public GrammarParser(GrammarRuleset grammarRuleset)
        {
            m_GrammarRuleset = grammarRuleset;
        }

        public void Parse(TokenSet tokens)
        {
            Debug.Log("[GrammarParser] Hello World!");
            m_Tokens = tokens;
        }

        public void ParseToken()
        {
            
        }

        private void ParseNext()
        {

        }
    }
}
