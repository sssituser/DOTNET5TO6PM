using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1000);
            list.Add(500);
            list.Add("abc");
            list.Add("6.7");
            list.Add(1000);
            list.Add(null);
            foreach (object ob in list)
            {
                Console.WriteLine(ob);
            }
            Console.WriteLine("After deleting the element");
            list.Remove(1000);
            foreach (object ob in list)
            {
                Console.WriteLine(ob);
            }


        }
    }
}
