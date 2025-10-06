using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConcept
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            int[][] gArray = new int[4][];
            gArray[0]= new int[4];
            gArray[1]= new int[3];
            gArray[2]= new int[5];
            gArray[3]= new int[6];
            Console.WriteLine("Enter elements for jagged Array");
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < gArray[i].Length; j++) 
                {
                    gArray[i][j]=int.Parse(Console.ReadLine());
                }
             }


            Console.WriteLine("Jagged Array Elements are");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < gArray[i].Length; j++)
                {
                    Console.Write($"{gArray[i][j]}\t");
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
