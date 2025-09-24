using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPrograms
{
    internal class Program4
    {
        //Write a read elements for an array of row size and col size2 and Display them in form matrix.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Array with Reactangular Dimension : ");
            int[,] Array1 = new int[2, 3];
            for (int i = 0; i < Array1.GetLength(0) ; i++) {
                for (int j = 0; j < Array1.GetLength(1); j++)
                {
                    Array1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Display the Array in MAtric Form : ");
            for (int i = 0; i < Array1.GetLength(0); i++) {
                for (int j = 0; j < Array1.GetLength(1); j++) {

                    Console.Write($"{Array1[i,j]}\t");
                    
                }
                Console.WriteLine();
            }
            
        }
    }
}
