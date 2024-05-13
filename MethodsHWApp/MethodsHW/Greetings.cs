using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsHW
{
    public static class Greetings
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my app.");
            Console.WriteLine();
        }
        public static string GetUserName()
        {
            Console.Write("Enter user name: ");
            string output = Console.ReadLine();

            return output;
        }

        public static void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }
    }
}
