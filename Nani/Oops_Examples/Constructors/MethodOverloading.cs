using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class MethodOverloading
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Sum(double a, double b)
        {

            return a + b;
        }
        public double Sum(double a, int b)
        {
            return a + b;
        }
        public double Sum(int a, double b)
        {

            return a + b;
        }
        static void Main(string[] args)
        {
            MethodOverloading sum1=new MethodOverloading();
            Console.WriteLine(sum1.Sum(100, 164));
            Console.WriteLine(sum1.Sum(21.2,23.9));

        }
    }
}
