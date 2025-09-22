using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class NumbersFrom1ton
    {
        /*Write a program to generate numbers from 1 to n  */
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i < a; i++) { 
                Console.WriteLine($"{i}");
            }
        }
    }
}
