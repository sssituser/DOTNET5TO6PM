using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.SetEmployee(111, "kiran", 50000);
            Console.WriteLine(employee.ToString()+"....");
           
            
        }
    }
}
