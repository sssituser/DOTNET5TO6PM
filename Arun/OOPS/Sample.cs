using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    internal class Sample
    {
        internal static int Id = 111;
        internal static string Name = "abc";
        internal static void Display()
        {
            Console.WriteLine("Hi this is display method");
        }
        internal static void Show()
        {
            Console.WriteLine($"ID :{Id}\tName : {Name}");
        }
    }
}
