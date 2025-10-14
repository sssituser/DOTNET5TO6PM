using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Methodsexamples
{
    internal class Class14
    {
        public static string  GetAmicablePairs(int start,int end)
        {
            string list = string.Empty;
            int totalsum = 0;
            for (int i = start; i < end; i++)
            {
                int sum1 = SumOfDivisors(i);
                if (sum1 > i && sum1 <= end)
                {
                    int sum2 = SumOfDivisors(sum1);
                    if (sum2 == i)
                    {
                        list += $"({i}, {sum1})\n";
                        totalsum += i + sum1;
                    }
                }

            }
            list += $"\nTotal Sum of Amicable Numbers = {totalsum}";
            return list;
        }
        
        public static int SumOfDivisors(int num)
        {
            int sum = 0;
            for (int i = 1; i < num;i++)
            {
                if(num%i==0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter start value");
            int start=int.Parse(Console.ReadLine());


            Console.WriteLine("enter end value");
            int end = int.Parse(Console.ReadLine());


            Console.WriteLine(GetAmicablePairs(start, end));
            

        }
    }
}
