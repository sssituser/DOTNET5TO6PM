using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class A
    {
        public void show()
        {
            Console.WriteLine("Hi I am show method from class A");
        }
        public void Display()
        {
            Console.WriteLine("Hi I am display method from class A");
        }
    }
    class B : A
    {
        public void Hi()
        {
            Console.WriteLine("Hi I am hi method from class B");
        }
        public void Bye()
        {
            Console.WriteLine("Hi I am Bye method from class B");
        }
    }
    internal class SingleInheritance
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.show();
            b.Display();
            b.Hi();
            b.Bye();
        }

    }
}
