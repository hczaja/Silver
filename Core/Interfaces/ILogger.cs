namespace Core.Interfaces;

public interface ILogger
{
    void LogTrace(string message);
    void LogDebug(string message);
    void LogWarning(string message);
    void LogError(string message);
}
