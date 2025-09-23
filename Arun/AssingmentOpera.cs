using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AssingmentOpera
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine($"a = {a}\tb = {b}");
            a += b; // a = a + b   // a = 30
            Console.WriteLine($"a = {a}"); // a = 30
            a -=b; // a = a - b  // a = 10
            Console.WriteLine($"a = {a}");
            a *= b; // a = a * b // a = 200
            Console.WriteLine($"a = {a}");
            a /= b; // a = a / b a = 10
            Console.WriteLine($"a = {a}");  

        }
    }
}
