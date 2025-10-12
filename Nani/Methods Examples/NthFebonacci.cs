using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class NthFebonacci
    {
        public static int NthFebo(int num)
        {
            
            int num1 = 0;
            int num2 = 1;
            
            
            for (int i = 1; i < num - 1; i++)
            {
                 int sum = num1 + num2;
                 num1 = num2;
                 num2 = sum;
            }
             return num2;                      
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a position : ");
            int num=int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine($"{num}th position has value : {NthFebo(num)}");
            }
            else
            {
                Console.WriteLine($"{num}th position does not contain a value");
            }

        }
    }
}
