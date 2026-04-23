using SingletonPattern;


var data = FileReader.Instance;
var city = "Tashkent";

Console.WriteLine($"{city} has {data.GetPopulation(city)} population.");
