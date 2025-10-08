using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Methodsexamples
{
    internal class Class3
    {
        public static bool IsAdam(int num)
        {
            return Program.Square(num) == Class1.Reverse(Program.Square(Class1.Reverse(num)));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            if(IsAdam(num))
            {
                Console.WriteLine($"given number {num} is adam number");
            }
            else
            {
                Console.WriteLine($"given number {num}is not an adam number");
            }
        }
    }    
}
