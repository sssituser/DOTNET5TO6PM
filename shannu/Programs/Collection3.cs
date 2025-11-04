using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Collection3
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

          list.Remove(1);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Count Element is "+list.Count);
            
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            list.RemoveAt(2);
        }
    }
}
