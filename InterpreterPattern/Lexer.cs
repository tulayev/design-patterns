using InterpreterPattern.Core;

namespace InterpreterPattern
{
    internal class Lexer
    {
        private readonly string _input;
        private int _pos;

        public Lexer(string input)
        {
            _input = input.Trim();
        }

        public List<Token> Tokenize()
        {
            var tokens = new List<Token>();

            while (_pos < _input.Length)
            {
                var c = _input[_pos];

                if (char.IsWhiteSpace(c))
                {
                    _pos++;
                    continue;
                }

                if (char.IsDigit(c))
                {
                    var num = string.Empty;

                    while (_pos < _input.Length && char.IsDigit(_input[_pos]))
                    {
                        num += _input[_pos++];
                    }

                    tokens.Add(new Token(TokenType.Number, num));
                    continue;
                }

                var token = c switch
                {
                    '+' => new Token(TokenType.Plus, "+"),
                    '-' => new Token(TokenType.Minus, "-"),
                    '*' => new Token(TokenType.Multiply, "*"),
                    _ => throw new Exception($"Unknown character: {c}")
                };

                tokens.Add(token);
                _pos++;
            }

            tokens.Add(new Token(TokenType.EOF, string.Empty));

            return tokens;
        }
    }
}
