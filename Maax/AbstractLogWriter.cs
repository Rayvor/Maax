using System;

namespace Maax
{
    public abstract class AbstractLogWriter : ILogWriter
    {
        public void LogError(string message)
        {

        }

        public void LogInfo(string message)
        {

        }

        public void LogWarning(string message)
        {

        }

        public abstract void LogWriting(string message);
    }
}
