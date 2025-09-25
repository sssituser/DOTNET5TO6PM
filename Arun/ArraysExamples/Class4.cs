using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConcept
{
    internal class Class4
    {
        static void Main(string[] args)
        {                              
            int[,] a = new int[2, 3] { {12,13,14 }, {45,67,89 } };// Initi
            for(int i = 0; i < 2; i++) // row
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
