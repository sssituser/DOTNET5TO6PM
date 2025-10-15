using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class EmployeeConstructor
    {
        int employeeId;
        string empName;
        int salary;

        public EmployeeConstructor()
        {
            Console.WriteLine("Hii,This is defualt");
            employeeId = 1;
            empName = "Nani";
            salary = 25000;
            Console.WriteLine("Bye");

        }
        public EmployeeConstructor(int employeeId, string empName, int salary)
        {
            Console.WriteLine("Hii,This is parameterised Constructor");
            this.employeeId = employeeId;
            this.empName = empName;
            this.salary= salary;
            Console.WriteLine("Bye");
        }
        public void GetEmployeeDetails()
        {
            Console.WriteLine($"Employee Id : {employeeId}\nEmployee name : {empName}\nEmployee salary : {salary}");
        }

    }
}

