using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConcept
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            
            int[] array = { 45, 67, 89, 112, 34, 66 };

            // Displaying array elements before sorting
            foreach(int element in array)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Sotered Elements");
            for (int i = 0; i < array.Length; i++) { // i = 0 
                for (int j = i + 1; j < array.Length; j++) {// j = 1 j = 2 j = 3
                    if (array[i] > array[j])
                    {
                        int copy = array[j];
                        array[j] = array[i];
                        array[i] = copy;
                    }
                }
            }
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
