using Core.Interfaces;

namespace Core.Tools;

public class ConsoleLogger : ILogger
{
    private const string DEBUG = "DEBUG";
    private const string ERROR = "ERROR";
    private const string WARNING = "WARNING";

    public void LogDebug(string message) => Log(DEBUG, message);

    public void LogError(string message) => Log(ERROR, message);

    public void LogWarning(string message) => Log(WARNING, message);

    private void Log(string verbose, string message)
    {
        DateTime now = DateTime.Now;
        Console.WriteLine($"{now.TimeOfDay} [{verbose}]: {message}");
    }
}
