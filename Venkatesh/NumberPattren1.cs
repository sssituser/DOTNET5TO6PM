using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class NumberPattren1
    {
      /*  1

        1	2

        1	2	3

        1	2	3	4

        1	2	3	4	5
        ==================================== */
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num=int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <=i; j++)
                {

                    Console.Write($"{j}\t");

                }

                Console.WriteLine("\n");
            }
        }
    }
}
