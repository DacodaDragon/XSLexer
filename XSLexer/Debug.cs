﻿using System;

namespace XSLexer
{
    static class Debug
    {
        public static void Show(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
        }

        public static void Log(object message) => Log(message.ToString());
        public static void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Log: " + message);
        }

        public static void Imp(object message) => Imp(message.ToString());
        public static void Imp(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Log: " + message);
        }

        public static void Error(object message) => Error(message.ToString());
        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Err: " + message);
        }

        public static void Warn(object message) => Warn(message.ToString());
        public static void Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("War: " + message);
        }

        public static void Pause()
        {
            Console.ReadKey(true);
        }
    }
}
