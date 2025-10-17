using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Class1
    {
        public static void Sum(int x,int y)
        {
            Console.WriteLine($"sum is {x+y}");
        }
        public static void Sum(int x, int y,int z)
        {
            Console.WriteLine($"sum is {x + y + z}");
        }
        public static void Sum(float x,float y,float z)
        {
            Console.WriteLine($"sum is {x+y+z}");
        }
        static void Main(string[] args)
        {
            Program.Show(56, 67);
            Program.Show(5.6, 6.7);
            Console.WriteLine(6);
            Console.WriteLine(6.7);
            Console.WriteLine("Hello");
            Console.WriteLine(true);
            Sum(4, 5);
            Sum(4,5,6);
            Sum(5.6F, 8.9F, 5.6F);


        }
    }
}
