using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class MathShortcuts
    {
        public static double Add(double x, double y)
        {
            //Console.WriteLine($"The value of {x} + {y} = {x + y}");
            return x + y;
        }

        public static void AddAll(double[] values)
        {
            double results = 0;

            foreach (double value in values) 
            { 
                results += value;
            }

            Console.WriteLine($"The total is {results}");

            //return results;
        }
    }
}
