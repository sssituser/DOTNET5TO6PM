using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPrograms
{
    internal class Program3
    {
        //Sorting the elements in descending order
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an array : ");
            int[] Array = new int[3];

            for (int i = 0; i < 3; i++) {
                Array[i]=int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sorted Elements in Array are :");
            for (int i = 0; i < 3; i++) {
                for (int j = i + 1; j < 3; j++) {
                    if (Array[i] < Array[j]) {
                        int Temp = Array[j];
                        Array[j] = Array[i];
                        Array[i] = Temp;
                    }
                }
                Console.WriteLine($"{Array[i]}");
            }
            
        }
    }
}
