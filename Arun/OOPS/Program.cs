
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test hum1 =new Test();
            hum1.name = "abc";
            Console.WriteLine(hum1.name);
            Console.WriteLine(hum1.contact);
            Console.WriteLine(hum1.address);


            hum1.ShowInfo();

            Test hum2 = new Test();
            Console.WriteLine(hum2.name);
            Console.WriteLine(hum2.contact);
            Console.WriteLine(hum2.address);
            hum2.ShowInfo();
        }
    }
}
