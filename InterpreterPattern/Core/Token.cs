namespace InterpreterPattern.Core
{
    internal class Token
    {
        public TokenType Type { get; }
        public string Value { get; }
        
        public Token(TokenType type, string value)
        {
            (Type, Value) = (type, value);
        }

        public override string ToString()
        {
            return $"[{Type}: '{Value}']";
        }
    }
}
