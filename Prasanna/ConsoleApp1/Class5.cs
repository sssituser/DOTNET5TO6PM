using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the starting number");
            int start = int.Parse (Console.ReadLine());
            int square = start * start;
            int cube = start * start*start;
            Console.WriteLine($"{start} square of {square} \n{start} cube of {cube}");
        }
    }
}
