using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConcept
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            int[] array1 = {45,67,89,23 };
            int[] array2 = { 23,45, 67, 8 };
            int[] array3 = new int[4];
            for (int i = 0; i < array1.Length; i++)// i = 1
            {
                array3[i] = array1[i] + array2[i];
            }

            Console.WriteLine("Result array Elements");

            foreach (int i in array3)
            {
                Console.WriteLine(i);
            }

        }
    }
}
