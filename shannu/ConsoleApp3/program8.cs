using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class program8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number :");
            String num=(Console.ReadLine());

            Console.WriteLine("=====================================");
            foreach (char item in num)

            {
                
                Console.Write($"{item}\t");
            }
            
        }
    }
}
