using CommandPattern.Commands;

namespace CommandPattern.Invokers
{
    internal class TextEditor
    {
        private readonly Stack<ICommand> _history = new();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _history.Push(command);
        }

        public void Undo()
        {
            if (_history.TryPop(out var command))
            {
                command.Undo();
            }
            else
            {
                Console.WriteLine("[Editor] Nothing to undo.");
            }
        }
    }
}
