using System;
using System.Collections;
using System.Configuration;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            //Stack follow LIFO last info First

            Stack s =new Stack();
            s.Push(10);
            s.Push("Test");
            s.Push(6.7);
            s.Push(true); // pushing the elements into the statckk
            Console.WriteLine("Elements present in the stack");
            foreach(object ob in s)
            {
                Console.WriteLine(ob); 
            }


            Console.WriteLine($"Elements Present in the Stack are :{s.Count}");
            Console.WriteLine($"Top element in stack  :{s.Peek()}");
            Console.WriteLine($"Deleted Elements is :{s.Pop()}");

            Console.WriteLine("Elements present in the stack");
            foreach (object ob in s)
            {
                Console.WriteLine(ob);
            }

            Console.WriteLine(s.Contains("kiran"));












        }
    }
}
