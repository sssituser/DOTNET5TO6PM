using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class ReadingArray
    {
        //Write a program to read 5 integer elements and show display the elements

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Elements :");
            int[] array = new int[5];

            for(int i= 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            
         /*   for(int i=0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");             
            }                                       */

            foreach(int i in array)
            {
                Console.Write($"{i}\t");
            }
        }
    }
}
