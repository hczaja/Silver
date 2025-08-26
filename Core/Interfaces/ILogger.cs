namespace Core.Interfaces;

public interface ILogger
{
    void LogDebug(string message);
    void LogWarning(string message);
    void LogError(string message);
}
