using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class WhileEx1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter start value : ");
            int start = int.Parse(Console.ReadLine());   //start = 1;
            Console.Write("Enter End value : ");
            int end = int.Parse(Console.ReadLine());  // end = 5;
           
            while (start <= end) //1<=5 T, 2<=5 T, 3<=5 T, 4<=5 T, 5<=5 T, 6<=5 F
            {
                Console.WriteLine(start);
                start++;
            }

        }
    }
}
