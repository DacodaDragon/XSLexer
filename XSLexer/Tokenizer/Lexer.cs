using System.Diagnostics;

namespace XSLexer.Lexing
{
    class Lexer
    {
        public Tokenizer m_TokenNizer;
        public TokenReplacer m_TokenReplacer;

        public Lexer(LexConfig config)
        {
            m_TokenNizer = new Tokenizer(config);
            m_TokenReplacer = new TokenReplacer(config);
        }

        public TokenSet Lex(string code)
        {
            Debug.Log("[Lexer] Starting first phase Tokenization!");
            Stopwatch stopwatch = Stopwatch.StartNew();
            TokenSet set = m_TokenNizer.Tokenize(code);
            Debug.Log($"[Lexer] Done! {stopwatch.ElapsedMilliseconds}ms elapsed!");

            Debug.Log("[Lexer] Starting second phase Tokenization!");
            stopwatch = Stopwatch.StartNew();
            set = m_TokenReplacer.Process(set);
            stopwatch.Stop();
            Debug.Log($"[Lexer] Done! {stopwatch.ElapsedMilliseconds}ms elapsed!");

            Debug.Show(set.ToString(), System.ConsoleColor.Cyan);

            Debug.Pause();

            return set;
        }
    }
}
