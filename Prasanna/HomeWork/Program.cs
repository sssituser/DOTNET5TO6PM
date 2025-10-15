using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Employee
    {
        int EmpId;
        string EmpName;
        int EmpSalary;

        public Employee()
        {
            EmpId = 111;
            EmpName = "Prasanna";
            EmpSalary = 10000;

        }
        public Employee(int empId, string empName, int empSalary)
        {
            EmpId = empId;
            EmpName = empName;
            EmpSalary = empSalary;
        }
        public void Getshow()
        {
            Console.WriteLine($"Employee ID:{EmpId}\nEmployee NAme:{EmpName}\nEmployee Salary:{EmpSalary }");
        }
    }
}
