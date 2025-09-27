using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class NumberPattren2
    {
        /*1

        2	2

        3	3	3

        4	4	4	4	

        5	5	5	5	5*/

        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for(int j = 1; j <= i;j++)
                {
                    Console.Write($"{i}\t");

                }
                Console.WriteLine("\n");
            }
        }
    }
}
