using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    internal class Program
    {
        internal static string id = "222";
        internal static string name = "lucky";
        internal static void display()
        {
            Console.WriteLine("hi this is display method");
        }
        internal static void show()
        {
            Console.WriteLine($"ID:{id}\nName:{name}");
        }
    }
}

