using System;

namespace XSLexer
{
    static class Debug
    {
        static void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Log: " + message);
        }

        static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Err: " + message);
        }

        static void Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("War: " + message);
        }

    }
}
