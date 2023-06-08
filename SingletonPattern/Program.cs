using SingletonPattern;

var data = FileReader.Instance;
string city = "Tashkent";
Console.WriteLine($"{city} has {data.GetPopulation(city)} population.");
