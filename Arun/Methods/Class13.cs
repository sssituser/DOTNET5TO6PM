using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehodsExample
{
    internal class Class13
    {
        public static string GetAmicablePairs(int begin,int end )//220,284
        {
            string res = string.Empty;
            int aSum = 0;
            for(int i = begin; i < end; i++)
            {
                int sum = FactorsSum(i);
                if (FactorsSum(sum) == i)
                {
                    if (i != sum)
                    {
                        if (!res.Contains(sum + " " + i))
                        {
                            res += i + " " + sum + "\n";
                            aSum += i + sum;
                        }
                    }
                }
            }
            return res+"\nAsum is "+aSum;
        }

        private static int FactorsSum(int num) // 220
        {
            int res = 0;
            for(int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    res += i;
                }
            }
            return res;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter start value : ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter end value : ");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine(GetAmicablePairs(start,end));
        }
    }
}
