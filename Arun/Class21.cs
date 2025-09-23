using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class21
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            int num = int.Parse(Console.ReadLine());
            int k = 1;
            for (int i = 1; i <= num; i++) // i = 2
            {
                for(int j = 1; j <= i; j++) // j = 1 j=2
                {
                    Console.Write($"{k++}\t\t");
                }
                Console.WriteLine("\n\n");
            }

            for(int i = num - 1; i >= 1; i--)  // i = 4 4>=1  i =3
            {
                for(int j = 1;j<=i; j++)  // j = 1 1<=4  j = 2  j = 3<=4 j = 4 4<=4
                {
                    Console.Write($"{k++}\t\t"); // 6   7     8  9
                }                                  
                Console.WriteLine("\n\n");
            }

        }
    }
}
