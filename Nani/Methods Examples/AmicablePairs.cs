using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class AmicablePairs
    {
        public static string AmicableList(int start, int end)//220-->factsum(284)-->factsum(220)
        {
            string list = string.Empty;
            for (int i = start; i < end; i++)
            {
                int Fsum1 = FactSum(i);
                int Fsum2 = FactSum(Fsum1);
                if(i==Fsum2 && i !=Fsum1 && i<Fsum1)
                {
                    list += $"{i}  {Fsum1}\n";

                }
            }
            
            return list;
        }
        public static int FactSum(int num)
        {
            int sum = 0;
            for(int i = 1; i < num;i++)
            {

                if (num %i==0)
                {
                    sum += i;
                }
            }
            return sum;

        }
        

        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter end value : ");
            int end =int.Parse(Console.ReadLine());

            Console.WriteLine(AmicableList(start, end));
            
        }
    }
}
