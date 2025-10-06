using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConcept
{
    internal class Class14
    {
        static void Main(string[] args)
        {
            string x = "abc"; // String is Immutabe(can't changeble)

            Console.WriteLine(x.ToUpper());
            Console.WriteLine(x);
            Console.WriteLine(x.ElementAt(1));
            Console.WriteLine(x.IndexOf('c'));
            Console.WriteLine();
           
        }
    }
}
