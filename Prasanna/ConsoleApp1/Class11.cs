using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int a = int.Parse(Console.ReadLine());//15
            int num = 1;
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + "\t");
                    num++;
                }
                Console.WriteLine();
            }
            for (int i = a-1; i >= 1; i--)
            {
                for(int j = 1;j <= i; j++)
                {
                    Console.Write(num + "\t");
                    num++;
                }
                Console.WriteLine();
            }
        }
    }
}
