using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsExamples
{
    internal class Employee : Department
    {
        int EmpId;
        string EmpName;
        int EmpSal;
        public Employee() { }
        public Employee(int empId, string empName, int empSal, int deptId, string deptName, string deptLocation, string deptHead): base(deptId,  deptName, deptLocation, deptHead)
        {
            EmpId = empId;
            EmpName = empName;
            EmpSal = empSal;
        }

        public override string ToString()
        {
            return $"empID: {EmpId}\t empNa,e : {EmpName}\t empSal : {EmpSal} deptId :{DeptId}, deptName : {DeptName}, deptLocation : {DeptLocation}, deptHead : {DeptHead}";
        }

        static void Main(string[] args)
        {
            Employee employee = new Employee(12,"shannu",20000,123,"HR","hyd","shannu");
            Console.WriteLine(employee);
        }
    }
}
