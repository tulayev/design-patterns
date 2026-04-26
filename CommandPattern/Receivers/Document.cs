namespace CommandPattern.Receivers
{
    internal class Document
    {
        private string _content = string.Empty;

        public void Append(string text)
        {
            _content += text;
            Console.WriteLine($"[Doc] Content: '{_content}'");
        }

        public void DeleteLast(int count)
        {
            _content = _content[..^count];
            Console.WriteLine($"[Doc] Content: '{_content}'");
        }
    }
}
