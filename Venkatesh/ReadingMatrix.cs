using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class ReadingMatrix
    {

        //Write a read elements for an array of row size and col size:3,2
        static void Main(string[] args)
        {


            int[,] matrix = new int[2, 3];

            Console.WriteLine("Enter matrix elements : ");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());

                }

            }
            Console.WriteLine("The Matrix is : ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();




            }
        }
    }
}
