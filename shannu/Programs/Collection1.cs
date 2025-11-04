using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Collection1
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(12);
            st.Push("shannu");
            st.Push(4.3f);
            st.Push(4546.232);
            st.Push(true);

            foreach(var item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Number of Element is " + st.Count);
            //st.Pop();
            Console.WriteLine("Removed Element is " + st.Pop());
            Console.WriteLine("Number of Element is " + st.Count);

            Console.WriteLine(st.Peek());
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
        }
       
    }
}
