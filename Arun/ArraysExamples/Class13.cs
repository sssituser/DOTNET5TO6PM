using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConcept
{
    internal class Class13
    {
        static void Main(string[] args)
        {
            int[] a = { 34, 56, 78, 90, 34, 56, 77, 89 };

            var res = a.Distinct().ToArray();

            Array.Sort(res);
           

            foreach(int k in res)
            {
                Console.WriteLine(k);
            }
            
        }
    }
}
