namespace MementoPattern
{
    internal class History
    {
        private readonly Stack<Memento> _stack = new();

        public void Push(Memento m)
        {
            _stack.Push(m);
        }

        public Memento? Pop()
        {
            return _stack.TryPop(out var m) ? m : null;
        }
    }
}
