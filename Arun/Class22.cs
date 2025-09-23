using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class22
    {
        static void Main(string[] args)
        {
            string name = "kirankumar";

            Console.WriteLine($"Name : {name}");
            foreach(char ch in name)
            {
                Console.Write($"{ch}\t");
            }
        }
    }
}
