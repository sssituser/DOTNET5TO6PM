using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class IncrementDecrement
    {
        static void Main(string[] args)
        {
            // is calle Incrment operator
            int a = 10;
            Console.WriteLine($"a = {a}"); // a = 10
            Console.WriteLine($"a = {a++}");// a = 10
            Console.WriteLine($"a = {a}");  // a = 11
            Console.WriteLine($"a = {++a}"); // a = 12
        }
    }
}
