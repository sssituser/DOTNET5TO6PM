using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER ANY NUMBER : ");
            int Num = int.Parse(Console.ReadLine());
            char k = '*';
            for (int i = 1; i <= Num; i++)
            {
                for (int j = 1; j <= Num - i; j++)
                {
                    Console.Write($"\t");
                }
                

                for (int s = 1; s <= i; s++)
                {
                    Console.Write($"{k}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
