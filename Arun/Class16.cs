using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class16
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            int copy = num;
            int factSum = 0;
            while (num > 0)
            {
                int ld = num % 10;
                int i = 1;
                int fact = 1;
                while (i <= ld)
                {
                    fact = fact * i;
                    i++;
                }
                factSum = factSum + fact;
                num = num / 10;
            }
            if (copy == factSum)
            {
                Console.WriteLine($"{copy} is a Strong Number");
            }
            else
            {
                Console.WriteLine($"{copy} is not a Strong number");
            }
            
        }
    }
}
