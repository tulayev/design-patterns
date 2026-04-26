namespace CommandPattern.Commands
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}
