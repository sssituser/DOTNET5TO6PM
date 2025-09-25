using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConcept
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3,3];
            Console.WriteLine("Enter array elements");


            for(int i = 0; i < 3; i++)
            {
                for(int j = 0;j< 3; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Array elements are");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j]+"\t");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Diagonal elements are");

            for (int i = 0; i < 3; i++)
            {
                for(int j = 0;j<3; j++)
                {
                    if(i == j || i+j ==2)
                    {
                        Console.Write($"{a[i,j]}\t");
                    }
                    else
                    {
                        Console.Write($"\t");
                    }
                }
                Console.WriteLine();
            }


            Console.WriteLine("Other than Diagonal elements are");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j || i + j == 2)
                    {
                        Console.Write($"\t");
                    }
                    else
                    {
                        Console.Write($"{a[i, j]}\t");
                        
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
