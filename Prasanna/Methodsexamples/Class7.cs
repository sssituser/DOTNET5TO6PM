using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodsexamples
{
    internal class Class7
    {
        public static int fact(int num)
        {
            int fact = 1;
            for(int i=1;i<=num;i++)
            {
                fact = fact * i;

            }
            return fact;
        }
        public static bool IsStrong(int num)
        {
            int temp = num;
            int sum = 0;
            while(temp>0)
            {
                int digit = temp % 10;
                sum = sum + fact(digit);
                temp = temp / 10;
            }
            return sum == num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num=int.Parse(Console.ReadLine ());
            if (IsStrong(num))
            {
                Console.WriteLine($"given number {num} is strong number");
            }
            else
            {
                Console.WriteLine($"given number {num} is not strong number");
            }

        }
    }
}
