using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Name
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("enter your frnd name");
            string frndname = Console.ReadLine();
            Console.WriteLine($"my name is:{name}");
            Console.WriteLine($"my frnd name is:{frndname}");
        }
    }
}
