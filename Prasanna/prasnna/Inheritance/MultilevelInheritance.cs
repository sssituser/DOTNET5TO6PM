using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class AA
    {
        public void sum()
        {
            Console.WriteLine("hi I am sum method from class AA");
        }
        public void sub()
        {
            Console.WriteLine("hi i am sub method from class AA");
        }
    }
    class BB : AA
    {
        public void Mul()
        {
            Console.WriteLine("hi i am multiplication method from class BB");
        }
        public void Div()
        {
            Console.WriteLine("hi i am Division method from class BB");
        }
    }
    class CC : BB
    {
        public void Demo()
        {
            Console.WriteLine("Hi i am Demo method from class CC");
        }
        public void Test()
        {
            Console.WriteLine("Hi i am test method from class CC");
        }
    }
    internal class MultilevelInheritance
    {
        static void Main(string[] args)
        {
            CC c = new CC();
            c.sum();
            c.sub ();
            c.Mul ();
            c.Div ();
            c.Demo();
            c.Test();

        }


    }
}
