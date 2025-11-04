using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Collection2
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Removed Item is "+queue.Dequeue());
            Console.WriteLine("Top Item is " + queue.Peek());
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }

            queue.Clone();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
