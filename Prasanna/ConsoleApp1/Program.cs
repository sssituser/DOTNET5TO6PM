using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter end value");//end=1
            int end = int.Parse (Console.ReadLine());
            Console.WriteLine("enter start value");//start=20
            int start = int.Parse(Console.ReadLine());
            while (end <= start)
            {
                Console.WriteLine(start);
                start-=2;
            }
        }
    }
}
