using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MehodsExample
{
    internal class Class12
    {
        public static int PrimeNumsSum(int start,int end)
        {
            int pSum = 0;
            if(start<0 || end<0) 
                return -1;
            if(start>=end)
                return -2;
            for(int i = start; i<=end; i++)
            {
                if (IsPrime(i))
                {
                   
                    pSum += i;
                }

            }
            return pSum;
        }

        public static bool IsPrime(int num)
        {
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;

                }
            }
            return count == 2;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter start value : ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter end value : ");
            int end = int.Parse(Console.ReadLine());


            Console.WriteLine(PrimeNumsSum(start,end));

        }
    }
}
