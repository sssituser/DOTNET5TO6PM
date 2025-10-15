using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Class4
    {
        static void Main(string[] args)
        {

            Company c1 = new Company();
            c1.GetData();
            Console.WriteLine("\n\n");

            Company c2 = new Company("Wipro","Hyderabad");
            c2.GetData();
            Console.WriteLine("\n\n");
        }

    }
}
