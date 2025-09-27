using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConcept
{
    internal class Class12
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3,67,89,23,45,67 };  // a[0] => 1 a[1] =>2

            int max = a[0];// max = 1
           
            for (int i = 1; i < a.Length; i++) {
                if (a[i] > max) {
                    max = a[i]; 
                }
            }
            Console.WriteLine($"Max value is {max}");

            Console.WriteLine($"Max value in the array is {a.Max()} ");
            Console.WriteLine($"Min values is : {a.Min()}");

            Console.WriteLine("Array elements are");
            foreach (int k in a) { Console.WriteLine(k); }

            Array.Sort(a);

            Console.WriteLine("Displaying the elements after sorting in ascending");
            foreach (int k in a) { Console.WriteLine(k); }

            Array.Reverse(a);
            Console.WriteLine("Displaying the elements after sorting in descending");
            foreach (int k in a) { Console.WriteLine(k); }

            Console.WriteLine($"Sum of the array elements : {a.Sum()}");
            Console.WriteLine($"Average of the array elements :{a.Average()}");

        }
    }
}
