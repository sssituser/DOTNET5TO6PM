using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name :");
            string name = Console.ReadLine();
            Console.Write("Enter your Age :");
            string age = Console.ReadLine();
            Console.WriteLine($"Hello {name} your age is {age}");
        }
    }
}
