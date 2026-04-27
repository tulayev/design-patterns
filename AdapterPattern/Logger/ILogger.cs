namespace AdapterPattern.Logger
{
    internal interface ILogger
    {
        void LogInfo(string message);
        void LogError(string message);
        void LogWarning(string message);
    }
}
