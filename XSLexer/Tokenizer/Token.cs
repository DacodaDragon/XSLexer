namespace XSLexer.Lexing
{
    class Token
    {
        public string Type { get; set; }
        public string Value { get; }

        public Token(string Type, string Value)
        {
            this.Type = Type;
            this.Value = Value;
        }
    }
}
