using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsExamples
{
    internal class Department
    {
       protected int DeptId;
        protected string DeptName;
        protected string DeptLocation;
        protected string DeptHead;


        public Department() { }
        public Department(int deptId, string deptName, string deptLocation, string deptHead)
        {
            DeptId = deptId;
            DeptName = deptName;
            DeptLocation = deptLocation;
            DeptHead = deptHead;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
