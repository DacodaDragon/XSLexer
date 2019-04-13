namespace XSLexer.Lexer
{
    class Token
    {
        public string Type { get; }
        public string Value { get; }

        public Token(string Type, string Value)
        {
            this.Type = Type;
            this.Value = Value;
        }
    }
}
