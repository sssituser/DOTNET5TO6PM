using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExmplaes
{
    internal class Employee
    {
        int EmpId;
        string EmpName;
        int EmpSalary;
        

        public Employee() { //Constructor with out  parameter
            Console.WriteLine("Hi Iam Constructor with out parameter");
            EmpId = 111;
            EmpName = "abc";
            EmpSalary = 20000;
        }
        public Employee(int EmpId,string EmpName,int EmpSalary)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpSalary = EmpSalary;
            
        }
        public void ShowEmployee()
        {
            Console.WriteLine("Hi Iam ShowEmployoee Method");
            Console.WriteLine($"Employee ID :{EmpId}\nEmployee Name : {EmpName}\nEmployee Salary:{EmpSalary}");
        }
    }
}
