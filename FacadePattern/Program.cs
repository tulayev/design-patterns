using FacadePattern;


var squareGenerator = new MagicSquareGeneratorFacade();

foreach (var list in squareGenerator.Generate(2))
{
    foreach (var num in list)
    {
        Console.Write($"{num} ");
    }
    Console.WriteLine();
}
