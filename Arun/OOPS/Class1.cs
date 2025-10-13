using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.RegisterEmployee(123, "Prasanna", 50000);
            emp1.ShowEmployee();

            Employee emp2 = new Employee();
            emp2.RegisterEmployee(113, "Venkat", 60000);
            emp2.ShowEmployee();

            Employee emp3 = new Employee();
            emp3.RegisterEmployee(114, "Shanmukh", 70000);
            emp3.ShowEmployee();

        }
    }
}
