using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Factors
    {
        /* Write to program to find the factors of a given number

num = 10    factors : 1,2,5,10
num = 12    factors : 1,2,3,4,6,12 */
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter a Number : ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Factors of {num} are:");
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
                Console.WriteLine(" Enter a Number : ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Not Factors of {num1} are:");
                for (int j = 1; j <= num; j++)
                {
                    if ((num1 % j)!= 0)
                    {
                        Console.WriteLine($"{j}");
                    }




                }
        }
    }
}
