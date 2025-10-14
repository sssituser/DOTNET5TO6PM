using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Integer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a value");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter b value");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"a is :{a}\nb is :{b}");
        }
    }
}
