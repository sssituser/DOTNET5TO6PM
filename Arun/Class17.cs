using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class17
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine()); // 5
            int start = 1; int fsum = 0;
           do
            {
                if (num % start == 0)
                {
                    fsum = fsum + start;
                }
                start++;
            } while (start < num);



            if (fsum == num)
            {
                Console.WriteLine($"{num} is a perfect number");
            }
            else
            {
                Console.WriteLine($"{num} is not a perfect number");
            }
        }
    }
}
