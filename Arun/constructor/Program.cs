using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExmplaes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee 1 object");
            Employee emp1 = new Employee(); // constructo called
            emp1.ShowEmployee();
            Console.WriteLine("Employee 2 object");
            Employee emp2 = new Employee();
            emp2.ShowEmployee();

        }
    }
}
