using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class A
    {
        public void Show()
        {
            Console.WriteLine("Hi Show method from class A");
        }
        public void Display()
        {
            Console.WriteLine("Hi this Display method from class A");
        }
    }
    class B : A { 
        public void Hi()
        {
            Console.WriteLine("Hi Iam Hi method from class B");
        }
        public void Bye()
        {
            Console.WriteLine("Hi Iam Bye method from class B");
        }
    }
    class C : B
    {
        public void Demo()
        {
            Console.WriteLine("Hi Iam demo method from class C");

        }
        public void Test()
        {
            Console.WriteLine("Hi this is Test method from class C");
        }
    }
    internal class Class5
    {
        static void Main(string[] args)
        {
            C p = new C();
            p.Show();
            p.Display();
            p.Hi();
            p.Bye();
            p.Demo();
            p.Test();
            
        }
    }
}
