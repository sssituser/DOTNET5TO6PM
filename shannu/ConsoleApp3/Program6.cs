using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program6
    {
        static void Main(string[] args)
        {

            Console.WriteLine("eNTER ANY nUMBER : ");
            int Num = int.Parse(Console.ReadLine());
            char k = '*';
            for (int i = Num; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{k}\t");
                }
                Console.WriteLine();
            }

            for (int i =1; i <= Num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{k}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
