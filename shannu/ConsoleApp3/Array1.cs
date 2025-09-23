using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Array1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number  : ");
            int[] array1= { 1, 2, 3 };
            for (int i = 0; i < array1.Length; i++) {
                Console.Write($"array{i} is : {array1[i]} \t");
            }
        }
    }
}
