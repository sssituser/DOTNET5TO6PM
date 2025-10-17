using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        public static void Show(int x,int y)
        {
            Console.WriteLine($"x = {x}\ty = {y}");
        }
        public static void Show(double x, double y)
        {
            Console.WriteLine($"x = {x}\ty = {y}");
        }
        public static void Show(string x, string y)
        {
            Console.WriteLine($"x = {x}\ty = {y}");
        }
        public static void Show(bool x, bool y)
        {
            Console.WriteLine($"x = {x}\ty = {y}");
        }
        static void Main(string[] args)
        {
            Show(10, 20);
            Show(20.5, 30.6);
            Show("kiran", "SSIT");
            Show(true, false);
        }
    }
}
