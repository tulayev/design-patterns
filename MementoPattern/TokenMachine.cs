public class TokenMachine
{
    public List<Token> Tokens { get; set; } = [];

    public Memento AddToken(int value)
    {
        return AddToken(new Token(value));
    }

    public Memento AddToken(Token token)
    {
        Tokens.Add(token);
        return new Memento(Tokens);
    }

    public void Revert(Memento m)
    {
        Tokens = m.Tokens.Select(x => new Token(x.Value)).ToList();
    }

    public override string ToString()
    {
        return string.Join(", ", Tokens.Select(x => x.Value));
    }
}