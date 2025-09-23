using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class18
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine()); // 5
            int start = 1; int count = 0;


            do
            {
                if (num % start == 0)
                {
                    count++;
                }
                start++;
            } while (start <= num);


           if (count == 2)
            {
                Console.WriteLine($"{num} is a prime number");
            }
            else
            {
                Console.WriteLine($"{num} is not a prime number");
            }
        }
    }
}
