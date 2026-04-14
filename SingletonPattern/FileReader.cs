using MoreLinq;
using MoreLinq.Experimental;

namespace SingletonPattern
{
    public class FileReader : IFileReader
    {
        private static readonly Lazy<FileReader> _instance = new(() => new());
        private readonly Dictionary<string, int> _cities;

        public static FileReader Instance => _instance.Value;

        private FileReader()
        {
            Console.WriteLine("Getting data...");

            _cities = File.ReadAllLines("Cities.txt")
                .Batch(2)
                .ToDictionary(
                    x => x.ElementAt(0).Trim(),
                    x => int.TryParse(x.ElementAt(1), out var num) ? num : 0
                );
        }

        public int GetPopulation(string city)
        {
            return _cities[city];
        }
    }
}
