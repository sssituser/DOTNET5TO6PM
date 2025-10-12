using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class NumberPattren6
    {
        /*1
          2	 3
          4	 5	6
          7	 8	9	10
          11 12	13	14	15
          16 17	18	19
          20 21	22
          23 24
          25*/
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int num=int.Parse(Console.ReadLine());
            int x = 1;


            for (int i = 1; i <= num; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(x++ + "\t");
                }
                Console.WriteLine();
            }
            for(int i = num-1; i >=1;i--)
            {
                for( int j = 1; j <= i; j++)
                {
                    Console.Write($"{x++}\t");
                }
                Console.WriteLine();
            }

        }

    }
}
