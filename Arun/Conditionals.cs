using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Conditionals
    {
        static void Main(string[] args)
        {
            Console.Write("User Name : ");
            string uname = Console.ReadLine();
            Console.Write("Enter Password : ");
            string pwd = Console.ReadLine();
            if(uname=="admin" && pwd == "1234")
            {
                Console.WriteLine("Login succesfull....");
            }
            else
            {
                Console.WriteLine("Invalid Credentials");
            }


        }
    }
}
