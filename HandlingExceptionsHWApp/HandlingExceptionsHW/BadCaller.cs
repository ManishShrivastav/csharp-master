using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptionsHW
{
    internal class BadCaller
    {
        internal static void BadCall()
        {
            Dictionary<string, int> names = new Dictionary<string, int>();
            names.Add("Tim", 38);
            names.Add("Sue", 23);
            names.Add("Bob", 40);
            names.Add("Jane", 55);
            names.Add("Frank", 31);

            List<string> keys = new List<string>(names.Keys);

            for (int i = 0; i <= keys.Count; i++)
            {
                string name = keys[i];
                int age = names[name];
                try
                {
                    Console.WriteLine($"{name}: {age}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("We got an error.");
                    Console.WriteLine(ex.Message);
                    throw new Exception("There was an error handling our array", ex);
                }
            }
        }
    }
}
