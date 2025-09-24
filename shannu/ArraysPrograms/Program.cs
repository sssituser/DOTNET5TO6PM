using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to read 5 integer elements and show display the elements
            Console.WriteLine("Enter an Array");
            int[] array1 = new int[5];

            for (int i = 0; i < array1.Length; i++) {
                array1[i]= int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Display the Array : ");
            foreach (int i in array1) {
                Console.WriteLine(i);
            }
        }
    }
}
