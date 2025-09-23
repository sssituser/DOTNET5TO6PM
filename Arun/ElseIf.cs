using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ElseIf
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value : ");
            int a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.Write("ZERO");
            }
            else if (a == 1)
            {
                Console.WriteLine("ONE");
            }
            else if (a == 2)
            {
                Console.WriteLine("TWO");
            }else if(a == 3)
            {
                Console.WriteLine("THREE");
            }
            else
            {
                Console.WriteLine("You entered other than 0,1,2,3");
            }

        }
    }
}
