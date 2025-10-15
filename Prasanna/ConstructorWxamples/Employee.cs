using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorWxamples
{
    internal class Employee
    {
        int EmpId;
        string EmpName;
        int EmpSalary;
        public Employee()
        {
            EmpId = 1;
            EmpName = "abcd";
            EmpSalary = 10000;

        }
        public Employee(int EmpId,string EmpName,int EmpSalary)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpSalary = EmpSalary;
        }
        public void GetData()
        {
            Console.WriteLine($"Employee Id:{EmpId}\nEmployee Name:{EmpName}\n Employee Salary:{EmpSalary }");
        }

    }
}
