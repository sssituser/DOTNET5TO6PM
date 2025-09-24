using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DoubleExample
    {

        public static void Main(string[] args)
        {


            Console.WriteLine("Enter a Number");
            double myNumber1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Number");
            double myNumber2 = double.Parse(Console.ReadLine());

            Console.Write($"Sum of myNumber1 and myNumber2 is  {myNumber1 + myNumber2}");
            

        }

    }
}
