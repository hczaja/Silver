using Core.Interfaces;
using Core.Settings;

namespace Core.Loggers;

public class ConsoleLogger : ILogger
{
    private const string DEBUG = "DEBUG";
    private const string ERROR = "ERROR";
    private const string WARNING = "WARNING";

    public void LogDebug(string message)
    {
        if (Toggles.LogLevel <= 1)
            Log(DEBUG, message);
    }

    public void LogWarning(string message)
    {
        if (Toggles.LogLevel <= 2)
            Log(WARNING, message);
    }

    public void LogError(string message)
    {
        if (Toggles.LogLevel <= 3)
            Log(ERROR, message);
    }

    private void Log(string verbose, string message)
    {
        DateTime now = DateTime.Now;
        Console.WriteLine($"{now.TimeOfDay} [{verbose}]: {message}");
    }
}
