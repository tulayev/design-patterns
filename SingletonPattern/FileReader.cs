using MoreLinq;
using MoreLinq.Experimental;

namespace SingletonPattern
{
    public class FileReader : IFileReader
    {
        private readonly Dictionary<string, int> _cities;

        private static readonly Lazy<FileReader> _instance = new(() => new());

        public static FileReader Instance => _instance.Value;

        private FileReader()
        {
            Console.WriteLine("Getting data...");

            _cities = File.ReadAllLines("Cities.txt")
                .Batch(2)
                .ToDictionary(
                    x => x.ElementAt(0).Trim(),
                    x => int.TryParse(x.ElementAt(1), out int num) ? num : 0
                );
        }

        public int GetPopulation(string city) =>
            _cities[city];
    }
}
