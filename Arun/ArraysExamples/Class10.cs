using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConcept
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            int[][] a = new int[3][];
            a[0] = new int[] { 45, 67, 89 };
            a[1] = new int[] { 4, 5, 6, 7 };
            a[2] = new int[] { 56, 78 };
            for (int i = 0; i < a.Length; i++) {  // a.len = 3 a[0] => 3
                for(int j = 0; j < a[i].Length; j++)
                {
                    Console.Write($"{a[i][j]}\t");
                }
                Console.WriteLine("\n\n");
            }


        }
    }
}
