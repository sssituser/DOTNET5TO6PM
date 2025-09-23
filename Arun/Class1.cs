using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter start value : ");
            int start = int.Parse(Console.ReadLine());   //start = 2;
            Console.Write("Enter End value : ");
            int end = int.Parse(Console.ReadLine());  // end = 5;
            while(start<=end)
            {
                Console.WriteLine(start);
                start += 3;
            }
        }
    }
}
