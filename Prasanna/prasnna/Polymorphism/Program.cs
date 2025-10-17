using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        public static void show()
        {
            
        }
        public static void show(int x,int y)
        {
            Console.WriteLine($"x:{x}\ty:{y}");
        }
        public static void show(int x,string name,double y)
        {
            Console.WriteLine($"x:{x}\t\tName:{name}\t\ty:{y}");
        }
        public static void show(double x,double y)
        {
            Console.WriteLine($"x:{x}\t\ty:{y}");
        }
        public static void show(string x,string y)
        {
            Console.WriteLine($"Name1:{x}\t\tName2:{y}");
        }
        static void Main(string[] args)
        {
            show();
            show(10, 20);
            show(10, "Lucky", 10.2);
            show(10.3, 28.9);
            show("Lucky", "Honey");
        }
    }
}
