using Core.Interfaces;
using Core.Settings;

namespace Core.Loggers;

public class ConsoleLogger : ILogger
{
    private const string TRACE = "TRACE";
    private const string INFO = "INFO";
    private const string DEBUG = "DEBUG";
    private const string ERROR = "ERROR";
    private const string WARNING = "WARNING";

    public void LogTrace(string message)
    {
        if (Toggles.LogLevel <= 0)
            Log(TRACE, ConsoleColor.White, message);
    }

    public void LogDebug(string message)
    {
        if (Toggles.LogLevel <= 1)
            Log(DEBUG, ConsoleColor.Blue, message);
    }

    public void LogInfo(string message)
    {
        if (Toggles.LogLevel <= 2)
            Log(INFO, ConsoleColor.Blue, message);
    }

    public void LogWarning(string message)
    {
        if (Toggles.LogLevel <= 3)
            Log(WARNING, ConsoleColor.Yellow, message);
    }

    public void LogError(string message)
    {
        if (Toggles.LogLevel <= 4)
            Log(ERROR, ConsoleColor.Red, message);
    }

    private void Log(string severity, ConsoleColor color, string message)
    {
        DateTime now = DateTime.Now;
        Console.Write($"{now.TimeOfDay} [");
        Console.ForegroundColor = color;
        Console.Write($"{severity}");
        Console.ResetColor();
        Console.Write($"]: {message}{Environment.NewLine}");
    }
}
