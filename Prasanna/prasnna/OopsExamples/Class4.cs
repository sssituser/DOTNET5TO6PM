using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    internal class Class4
    {
        static void Main(string[] args)
        {


            Employee emp1 = new Employee();
            emp1.GetEmployee(100, "nani", "Guntur");
            emp1.ShowInfo();

            Employee emp2 = new Employee();
            emp2.GetEmployee(101, "lucky", "ongole");
            emp2.ShowInfo();
        }

    }
}
