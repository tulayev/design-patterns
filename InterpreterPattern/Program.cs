using InterpreterPattern;


Evaluate("3 + 5");
Evaluate("10 - 3 - 2");
Evaluate("2 * 4 + 1");
Evaluate("6 + 2 * 3");

static void Evaluate(string input)
{
    var tokens = new Lexer(input).Tokenize();
    var tree = new Parser(tokens).Parse();

    Console.WriteLine($"{input} = {tree.Interpret()}");
}
