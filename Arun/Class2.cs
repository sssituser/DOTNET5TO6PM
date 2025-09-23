using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class2
    {
        static void Main(string[] args)
        {
                // start = 10    end = 1
                Console.Write("Enter end value : ");
                int end = int.Parse(Console.ReadLine());  // end = 10
                Console.Write("Enter start value : ");
                int start = int.Parse(Console.ReadLine());   //start = 1;  
            while (end >= start)
            {
                Console.WriteLine(end);
                end--;
            }


        }
    }
}
