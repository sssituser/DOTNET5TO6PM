using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphism.Properties;

namespace Polymorphism
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Object 1 values");
            PolyEx obj1 = new PolyEx(10,20);
            obj1.ShowNums();
            Console.WriteLine("Object 2 values");
            PolyEx obj2 = new PolyEx(30,40);
            obj2.ShowNums();
            Console.WriteLine("Object 3 values ");
            PolyEx obj3 = new PolyEx();
            obj3 = obj1 + obj2;
            obj3.ShowNums();




        }
    }
}
