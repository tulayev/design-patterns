public class Memento
{
    public List<Token> Tokens { get; } = [];

    public Memento(List<Token> tokens)
    {
        Tokens = [.. tokens.Select(x => new Token(x.Value))];
    }
}
