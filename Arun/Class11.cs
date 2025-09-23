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
            Console.Write("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine()); // 5
            int start = 1; int fact = 1;
            while(start <= num) // 
            {
                fact = fact * start;// fact = 1*1=1 fact = 1*2=2 fact = 2*3=6 fact = 6*4=24 fact = 24*5=120
                start++;// 2 3 4 5 
            }
            Console.WriteLine($"Factorial is :{fact}");
        }
    }
}
