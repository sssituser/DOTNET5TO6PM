using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    internal class Employee
    {
        int EmpId;
        string EmpName;
        int EmpSal;
        public void SetEmployee(int EmpId,string EmpName,int EmpSal)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpSal = EmpSal;
        }
        public override string ToString()
        {
            return $"Employee Id :{EmpId}\tEmployee Name : {EmpName}\tEmployee Salary :{EmpSal}";
        }
        public void ShowEmployee()
        {
            Console.WriteLine($"Employee ID : {EmpId}\nEmployee Name : {EmpName}\nEmployee Salary : {EmpSal}");
        }
    }
}
