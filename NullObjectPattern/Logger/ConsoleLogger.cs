internal class ConsoleLogger : ILogger
{
    public void LogInfo(string message)
    {
        Console.WriteLine($"[INFO]  {message}");
    }

    public void LogWarning(string message)
    {
        Console.WriteLine($"[WARN]  {message}");
    }

    public void LogError(string message)
    {
        Console.WriteLine($"[ERROR] {message}");
    }
}
