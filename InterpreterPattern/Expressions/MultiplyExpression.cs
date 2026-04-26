namespace InterpreterPattern.Expressions
{
    internal class MultiplyExpression : IExpression
    {
        private readonly IExpression _left, _right;
        
        public MultiplyExpression(IExpression left, IExpression right)
        {
            (_left, _right) = (left, right);
        }

        public int Interpret()
        {
            return _left.Interpret() * _right.Interpret();
        }
    }
}
