using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class NumberPattren5
    {
        /*  1
            2	2
            3	3	3
            4	4	4	4
            5	5	5	5	5
            4	4	4	4
            3	3	3
            2	2	
            1*/
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num =int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i}\t");
                }
                Console.WriteLine();
            }
            for(int i = num-1; i >= 1;i--)
            {
                for(int j = 1; j <= i;j++)
                {
                    Console.Write($"{i}\t");

                }
                Console.WriteLine();    
            }
        }

    }
}
