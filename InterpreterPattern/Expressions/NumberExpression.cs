namespace InterpreterPattern.Expressions
{
    internal class NumberExpression : IExpression
    {
        private readonly int _value;
        
        public NumberExpression(int value)
        {
            _value = value;
        }

        public int Interpret()
        {
            return _value;
        }
    }
}
