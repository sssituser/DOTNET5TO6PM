using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class ArrayDescending
    {
        //Sorting the elements in descending order
        static void Main(string[] args)
        {
            Console.Write("Enter array size : ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            Console.WriteLine("Enter array elements : ");
            for(int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Array before sorting : ");
            for(int i=0;i<size;i++)
            {
                Console.Write($"{array[i]}\t");
            }
            for(int i=0;i<size; i++)
            {
                for(int j=i+1;j<size;j++)
                {
                    if (array[i] < array[j])
                    {
                        int copy=array[i];
                        array[i] = array[j];
                        array[j] = copy;
                        
                    }

                }
            }
            Console.WriteLine();
            Console.WriteLine("array after sorted :)");
            foreach(int i in array)
            {
                Console.Write($"{i}\t");
            }
        }
    }
}
