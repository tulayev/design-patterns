using InterpreterPattern.Core;
using InterpreterPattern.Expressions;

namespace InterpreterPattern
{
    internal class Parser
    {
        private readonly List<Token> _tokens;
        private int _pos;

        private Token Current => _tokens[_pos];

        public Parser(List<Token> tokens)
        {
            _tokens = tokens;
        }

        // Handles + and - (lower precedence)
        public IExpression Parse()
        {
            var left = ParseTerm();

            while (Current.Type == TokenType.Plus || Current.Type == TokenType.Minus)
            {
                var op = _tokens[_pos++].Type;
                var right = ParseTerm();

                left = op == TokenType.Plus
                    ? new AddExpression(left, right)
                    : new SubtractExpression(left, right);
            }

            return left;
        }

        private Token Consume(TokenType expected)
        {
            if (Current.Type != expected)
            {
                throw new Exception($"Expected {expected} but got {Current.Type}");
            }

            return _tokens[_pos++];
        }

        // Parses a single number
        private IExpression ParsePrimary()
        {
            var token = Consume(TokenType.Number);

            return new NumberExpression(int.Parse(token.Value));
        }

        // Handles * (higher precedence)
        private IExpression ParseTerm()
        {
            var left = ParsePrimary();

            while (Current.Type == TokenType.Multiply)
            {
                _pos++;
                var right = ParsePrimary();
                left = new MultiplyExpression(left, right);
            }

            return left;
        }
    }
}
