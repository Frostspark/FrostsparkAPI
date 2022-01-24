namespace Frostspark.API.Logging
{
    public abstract class Logger
    {
        public abstract void LogInfo(string source, string msg);

        public abstract void LogWarning(string source, string msg);

        public abstract void LogError(string source, string msg);

        public abstract void LogDebug(string source, string msg);

        public abstract void LogSuccess(string source, string msg);

    }
}
