using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConcept
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            int[,] a = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 6, 7, 8 }, };
            for (int i = 0; i < 3; i++)
            {
               for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{a[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
