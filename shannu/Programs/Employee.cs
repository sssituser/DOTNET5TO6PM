using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal abstract class Employee
    {
        protected int EmpId;
        protected string EmpName;

        public abstract void EmployeeDetails();
        public abstract void EmployeeDomain();

        public void SetEmployee()
        {
            Console.WriteLine("Enter Employee ID : ");
            EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name : ");
            EmpName= Console.ReadLine();    
        }
        public void GetEmployee()
        {
            Console.WriteLine($"Employee ID: {EmpId}\tEmployee Name : {EmpName}");
        }
    }
}
