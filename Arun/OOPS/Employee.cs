using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    internal class Employee
    {

        int empId;
        string empName;
        int empSal;  // Instance members or  class variables

        public void RegisterEmployee(int empId, string empName, int empSal/*local variables*/)
        {
            this.empId = empId;
            this.empName = empName;
            this.empSal = empSal;
        }
        public void ShowEmployee()
        {
            Console.WriteLine($"Employee ID :{empId}\nEmployee Name : {empName}\nEmployee Salary : {empSal}");
        }

    }
}
