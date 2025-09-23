using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value : ");
            float a = float.Parse(Console.ReadLine());  
            Console.Write("Enter b value : ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine($"sum of a and b is :{a+b}");
        }
    }
}
