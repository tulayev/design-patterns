
internal class TextEditor
{
    private string _content = string.Empty;

    public void Type(string text)
    {
        _content += text;
        Console.WriteLine($"[Editor] '{_content}'");
    }

    public Memento Save()
    {
        return new(_content);
    }

    public void Restore(Memento m)
    {
        _content = m.Content;
    }

    public string GetContent()
    {
        return _content;
    }
}
