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
            Console.Write("Enter a value : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b value : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Addition of a and b is : " + (a + b));
            Console.WriteLine($"Sum of a and b is : {a+b}");
            Console.WriteLine($"Sum of a and b is : {0}",a+b);
        }
    }
}
