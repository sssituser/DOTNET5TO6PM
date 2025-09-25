using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConcept
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            //================== Reading Elements========================
            int[] array = new int[5]; // Declaration of the Array
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < array.Length; i++) { 
                array[i] = int.Parse(Console.ReadLine());
            }
            //==========================Displaying the elements===========

            Console.WriteLine("Displaying Array Elements usig For loop : ");
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Dispalying the Array elements using foreach");
            foreach (int element in array) {
                Console.WriteLine(element);
            }





        }
    }
}
