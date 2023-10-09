using System;
namespace ConsoleApp.Libraries
{
    public class ConsoleLogger : ILogger
    {
        public LogLevels CurrentLogLevel { get; private set; }
        public ConsoleLogger(LogLevels currentLogLevel)
        {
            CurrentLogLevel = currentLogLevel;
        }

        public void Log(LogLevels logLevel, string message)
        {
            // Return if the log level is too high
            if (logLevel < CurrentLogLevel)
                return;

            switch (logLevel)
            {
                case LogLevels.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case LogLevels.Warn:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
               
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
