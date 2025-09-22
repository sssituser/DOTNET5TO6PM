using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class StartToEnd
    {
        static void Main(string[] args)
        {
            //Write program to generate numbers from the given start and end values.
            //Examples
            //      start = 1   end = 10
            //        1 2 3 4 5 6 7 8 9 10
            //        2,4,6,8,10,12,14,16,18,20
            //        given
            //start = 1;
            //end = 10;


            Console.Write("enter start number : ");
            int Start = int.Parse(Console.ReadLine());
            Console.Write("enter End number : ");
            int End = int.Parse(Console.ReadLine());

            while (Start <= End)
            {
                Console.WriteLine($"value = {Start}");
                Start++;
            }
            Console.ReadKey();
        }
    }
}
