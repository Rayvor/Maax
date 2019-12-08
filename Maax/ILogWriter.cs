namespace Maax
{
    public interface ILogWriter
    {
        void LogError(string message);

        void LogInfo(string message);

        void LogWarning(string message);
    }
}
