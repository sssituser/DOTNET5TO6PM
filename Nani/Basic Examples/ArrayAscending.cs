using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class ArrayAscending
    {
        //Sorting the elements in ascending order
        static void Main(string[] args)
        {
            Console.Write("Enter size of the array : ");
            int size=int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter array elements : ");
            for (int i = 0; i < size; i++)
            {
                array[i] =int.Parse( Console.ReadLine());

            }
            Console.WriteLine("The array is before sorting is : ");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{array[i]}\t");
            }
            Console.WriteLine();
            Console.WriteLine("The array after sorting is : ");
            for(int i = 0; i < size;i++)
            {
                for(int j = i+1; j < size;j++)
                {
                    if(array[i] > array[j])
                    {
                        int copy = array[i];//45
                        array[i] = array[j];//45
                        array[j]= copy;

                    }
                }
            }
            for(int i = 0; i < size; i++)
            {
                Console.Write($"{array[i]}\t");
            
            }
        }

    }
}
