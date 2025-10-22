using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Class4
    {
        public static void ShowValues(string x) // object x
        {
            //student p
            bool p = true;
            Console.WriteLine(p == bool.Parse(x));

        }
        static void Main(string[] args)
        {
            ShowValues("true");
        }
    }
}
