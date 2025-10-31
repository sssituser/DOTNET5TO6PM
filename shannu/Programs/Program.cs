using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Program:Employee
    {

        int a;
        int b;

        public Program() { }
        public Program(int a, int b) {
            this.a = a; 
            this.b = b;
        
        }
        public void GetDetails()
        {
            Console.WriteLine($"a={a}\tb={b}");
        }
        static void Main(string[] args)
        {
            Program program = new Program(20,10);
            program.SetEmployee();
            program.GetDetails();
            program.EmployeeDetails();
            program.EmployeeDomain();
            program.GetEmployee();
        }

        public override void EmployeeDetails()
        {
            Console.WriteLine($"Employee Id : {EmpId}\t Employee Name : {EmpName}");
        }

        public override void EmployeeDomain()
        {
            Console.WriteLine($"Employee Id : {EmpId}\t Employee Name : {EmpName}");
        }
    }
}
