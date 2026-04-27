using Serilog;

namespace AdapterPattern.Adapter
{
    internal class SerilogAdapter : Logger.ILogger
    {
        // SeriLog interface
        private readonly ILogger _serilog; 

        public SerilogAdapter()
        {
            _serilog = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message}{NewLine}")
                .CreateLogger();
        }

        public void LogInfo(string message)
        {
            _serilog.Information(message);
        }

        public void LogError(string message)
        {
            _serilog.Error(message);
        }

        public void LogWarning(string message)
        {
            _serilog.Warning(message);
        }
    }
}
