using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Prime
    {

        static void Main(string[] args)
        {

            int count = 0;
            Console.WriteLine(" Enter a Number : ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Factors of {num} are:");
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"{i}");
                    count++;
                }
            }
            if (count > 2)
            {
                Console.WriteLine($"Number {num} is not Prime number");

            }
            else
            {
                Console.WriteLine($"Number {num} is not Prime number");
            }

        }
        }
    }
