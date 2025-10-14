using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class strinex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter student name");
            string name = Console.ReadLine();
            Console.WriteLine("enter your father name");
            string fathername = Console.ReadLine();
            // Console.WriteLine(name);
            // Console.WriteLine(fathername);
            Console.WriteLine($"My Name is :{name}");
            Console.WriteLine($"My Father Name is :{fathername}");
               
        }
    }
}
