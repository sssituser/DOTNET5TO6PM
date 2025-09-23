using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
               Console.WriteLine($"+++++++++++++++++++++++++++++++++++++{i}");
                for (int j = 1; j <= i; j++)
                {
                   // Console.WriteLine(j);
                    Console.Write($"{j}\t");

                }
                Console.WriteLine();


            }
        }
    }
}
