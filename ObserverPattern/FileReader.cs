namespace ObserverPattern
{
    public static class FileReader
    {
        public static string GetApiKey => File.ReadAllLines(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "api_key.txt")).First();
    }
}
