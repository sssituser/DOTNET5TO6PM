using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodsexamples
{
    internal class Program
    {
        public static int Square(int num)
        {
            return num * num;
        }
        public static int add(int num1,int num2)
        {
            return num1 + num2;
        }
        public static int avg(int num1,int num2,int num3)
        {
            return (num1 + num2 + num3) / 3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"square of the number {Square(9)}");
            Console.WriteLine($"addition of two numbers {add(2,3)}");
            Console.WriteLine($"average of three numbers {avg(1, 2, 3)}");
        }
    }
}
