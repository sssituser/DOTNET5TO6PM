using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehodsExample
{
    internal class Program
    {
        public static int Square(int num)
        {
            return num * num;
        }
        public static int Sum(int num1, int num2)
        {

            return num1 + num2;
        }

        public static int Average(int num1, int num2, int num3)
        {

            return (num1 + num2 + num3) / 3;
        }


        static void Main(string[] args)
        {
            Console.WriteLine($"Square is {Square(5)}");//25
            Console.WriteLine($"Sum of two numbers {Program.Sum(6,7)}");//13
            Console.WriteLine($"Average of three numbers{Program.Average(1,2,3)}"); //2
        }
    }
}
