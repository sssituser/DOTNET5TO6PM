using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Employee
    {
        int empid;
        string empname;
        int empsalary;
        public void SetEmployee(int empid,string empname,int empsalary)
        {
            this.empid = empid;
            this.empname = empname;
            this.empsalary = empsalary;
        }
        public override string ToString()
        {
            return $"Employee Id :{empid}\tEmployee Name : {empname}\tEmployee Salary :{empsalary}";
        }
        public void ShowEmployee()
        {
            Console.WriteLine($"Employee Id:{empid}\nEmployee Name:{empname}\nEmployee Salary:{empsalary}");
        }
    }
}
