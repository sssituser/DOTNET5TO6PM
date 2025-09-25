using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConcept
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A matrix elements : ");
            int[,]a=new int[2,2];
            for(int i = 0; i <2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    a[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter B matrix elements : ");
            int[,] b = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("A matrix elements are");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{a[i,j]}\t");
                }
                Console.WriteLine("\n\n");
            }
            Console.WriteLine("B matrix elements are");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{b[i, j]}\t");
                }
                Console.WriteLine("\n\n");
            }
            Console.WriteLine("Sum of A and B matrix elements are");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{a[i, j] + b[i,j]}\t");
                }
                Console.WriteLine("\n\n");
            }
        }

    }
}
