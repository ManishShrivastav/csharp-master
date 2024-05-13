using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class RequestData
    {
        public static string GetAString(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            return output;
        }
    }
}
