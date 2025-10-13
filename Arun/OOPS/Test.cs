using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    internal class Test
    {
       public string name = "kiran";
       public string contact = "99999999";
       public string address = "Hyderabad";
        public void ShowInfo()
        {
            Console.WriteLine($"Name : {name}\nContact : {contact}\nAddress : {address}");
        }
    }
}
