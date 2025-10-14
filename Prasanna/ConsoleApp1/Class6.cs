using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse (Console.ReadLine());//5
            for (int i = 1; i <= num; i++)//1<=5  2<=5
            {
                for (int j = 1; j <= i; j++)//1<=1 1<=2
                {
                    Console.Write(j+"\t");// 1 2
                }
                Console.WriteLine();
            }
        }
    }
}
