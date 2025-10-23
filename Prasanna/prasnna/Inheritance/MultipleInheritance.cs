using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class AAA
    {
        protected int a;
        protected int b;
        public void Read()
        {
            Console.WriteLine("enter a value");
            a =int.Parse(Console.ReadLine());
            Console.WriteLine("enter b value");
            b =int.Parse(Console.ReadLine());
        }
        public void show()
        {
            Console.WriteLine($"a value:{a}\nb value:{b}");
        }
    }
    interface IBB
    {
        void sum();
        void sub();
        
    }
    interface ICC
    {
        void mul();
        void div();
    }
    class DDD:AAA,IBB,ICC
    {
        public void sum()
        {
            Console.WriteLine($"sum of :{a+b}");
        }
        public void sub()
        {
            Console.WriteLine($"Subtraction of:{a-b}");
        }
        public void mul()
        {
            Console.WriteLine($"Multiplication of:{a*b}");
        }
        public void div()
        {
            Console.WriteLine($"Division of:{a/b}");
        }
    }
    internal class MultipleInheritance
    {
        static void Main(string[] args)
        {
            DDD d = new DDD();
            d.Read();
            d.show();
            d.sum();
            d.sub();
            d.mul();
            d.div();

        }
    }
}
