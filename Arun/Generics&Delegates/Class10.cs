using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("abc");
            q.Enqueue(10);
            q.Enqueue(5.6);
            q.Enqueue('p');


            Console.WriteLine("Que elements are");
            foreach(object ob in q)
            {
                Console.WriteLine(ob);
            }
            Console.WriteLine($"Top element in the queue : {q.Peek()}");
            Console.WriteLine($"Deleted Element in the Que : {q.Dequeue()}");
            Console.WriteLine("Que elements are");
            foreach (object ob in q)
            {
                Console.WriteLine(ob);
            }

            

        }
    }
}
