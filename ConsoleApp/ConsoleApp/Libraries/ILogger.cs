using System;
namespace ConsoleApp.Libraries
{
    public enum LogLevels { Verbose, Warn, Error }
    public interface ILogger
    {
        public void Log(LogLevels level, string message);
    }
}
