using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class MultiInheritance
    {
        public void Method1()
        {
            Console.WriteLine("Hi I'm belongs to class MultiLevelInheritance method 1");
        }
    }
    class B : MultiInheritance
    {
        public void Method2()
        {
            Console.WriteLine("Hi I'm method 2 from class B");
        }
    }
        class C : B
        {
            public void Method3()
            {
                Console.WriteLine("Hi ,I'm method 3 from class c");

            }


        }
        class D
        {
            static void Main(string[] args)
            {
                C obj = new C();
                obj.Method1();
                obj.Method2();
                obj.Method3();


            }
        }
}
