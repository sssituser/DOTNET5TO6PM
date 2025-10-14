using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int a = int.Parse (Console.ReadLine());
            int square = a * a;
            Console.WriteLine($"the square of {a} is {square}");
        }
    }
}
