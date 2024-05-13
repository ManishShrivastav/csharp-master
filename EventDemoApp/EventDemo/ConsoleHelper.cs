using System;

namespace EventDemo
{
    public static class ConsoleHelper
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }
    }
}
