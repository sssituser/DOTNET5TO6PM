using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name :");
            string name = Console.ReadLine();
            Console.Write("Enter your Age :");  
            string age = Console.ReadLine();
            Console.Write("Enter your City :");
            string city = Console.ReadLine();
            Console.Write("Enter your Country :");
            string country = Console.ReadLine();
            Console.WriteLine("Name : {0}\nAge : {1}\nCity : {2}\nCountry :{3}",name,age,city,country);
        }
    }
}
