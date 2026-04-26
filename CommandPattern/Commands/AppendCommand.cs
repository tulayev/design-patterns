using CommandPattern.Receivers;

namespace CommandPattern.Commands
{
    internal class AppendCommand : ICommand
    {
        private readonly Document _doc;
        private readonly string _text;

        public AppendCommand(Document doc, string text)
        {
            _doc = doc;
            _text = text;
        }

        public void Execute()
        {
            _doc.Append(_text);
        }

        public void Undo()
        {
            _doc.DeleteLast(_text.Length);
        }
    }
}
