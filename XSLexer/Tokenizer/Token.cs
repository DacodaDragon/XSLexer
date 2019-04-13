namespace XSLexer.Lexing
{
    class Token
    {
        public string Type { get; set; }
        public string Value { get; }
        public int LineNumber { get; }

        public Token(string Type, string Value, int LineNumber)
        {
            this.Type = Type;
            this.Value = Value;
            this.LineNumber = LineNumber;
        }
    }
}
