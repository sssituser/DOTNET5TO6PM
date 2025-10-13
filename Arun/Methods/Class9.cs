using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehodsExample
{
    internal class Class9
    {
        public static string GetFizzBuzz(int start,int end)
        {
            string res = string.Empty;
            for (int i = start; i <= end; i++)
            {
                if(i%3==0 && i % 5 == 0)
                {
                    res += i + " FizzBuzz\n";
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter start value : ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter a end value : ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFizzBuzz(start,end));
        }
    }
}
