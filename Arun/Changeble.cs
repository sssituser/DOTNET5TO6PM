using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Changeble
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b value : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter c value : ");
            int c = int.Parse(Console.ReadLine());
            int max = a;  // 19,10,11
           
            if (b > max)
            {
                max = b; // max = 10
            }
            if(c > max)
            {
                max = c; // max = 11
            }
            Console.WriteLine($"{max} is max");


        }
    }
}
