using System.Diagnostics;

namespace XSLexer.Lexing
{
    class Lexer
    {
        public Tokenizer m_TokenNizer;
        public TokenReplacer m_TokenReplacer;
        public Structurizer m_Structurizer;

        public Lexer(LexConfig config, StructureConfig structureConfig)
        {
            m_TokenNizer = new Tokenizer(config);
            m_TokenReplacer = new TokenReplacer(config);
            m_Structurizer = new Structurizer(structureConfig);
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

            Debug.Log("[Grammar] Starting first phase structuration!");
            stopwatch = Stopwatch.StartNew();
            StructureToken[] stokens = m_Structurizer.Parse(set);
            stopwatch.Stop();
            Debug.Log($"[Grammar] Done! {stopwatch.ElapsedMilliseconds}ms elapsed!");


            for (int i = 0; i < stokens.Length; i++)
            {
                Debug.Show(stokens[i].ToString(), System.ConsoleColor.DarkGreen);
            }

            Debug.Pause();

            return set;
        }
    }
}
