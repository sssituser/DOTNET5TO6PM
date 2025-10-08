using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodsexamples
{
    internal class Class5
    {
        public static bool IsPerfect(int num)
        {
            int sum = 0;
            for (int i = 1; i <num; i++)
            {
                if (num % i== 0)
                {
                    sum = sum + i;
                }
            }
            return num == sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            if (IsPerfect(num))
            {
                Console.WriteLine($"given number {num} is perfect number");
            }
            else
            {
                Console.WriteLine($"given number {num}is not perfect number");
            }
        }
    }
}
