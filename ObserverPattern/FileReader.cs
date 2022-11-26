namespace ObserverPattern
{
    public static class FileReader
    {
        public static string GetApiKey => File.ReadAllLines("api_key.txt").First();
    }
}
