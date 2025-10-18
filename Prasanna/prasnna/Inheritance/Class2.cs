using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.SetEmployee(111, "Lucky", 30000);
            Console.WriteLine( (e1.ToString()));
            
        }
    }
}
