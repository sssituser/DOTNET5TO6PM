using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehodsExample
{
    internal class Class4
    {

        public static bool IsAdam(int num) // 12
        {
         return  Program.Square(num) == Class1.Reverse(Program.Square(Class1.Reverse(num)));
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number :");
            int num = int.Parse(Console.ReadLine());
            if (IsAdam(num))
            {
                Console.WriteLine($"{num} is Adam");
            }
            else
            {
                Console.WriteLine($"{num} is not an Adam");
            }
        }
    }
}
