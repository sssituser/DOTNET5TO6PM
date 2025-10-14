using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    internal class Employee
    {
        static int eid;
        static string ename;
        static string eaddress;
        public void GetEmployee(int eID,string eName,string eAddress)
        {
            eid = eID;
            ename = eName;
            eaddress = eAddress;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"EmpId:{eid}\nEmpName:{ename}\nEmpAddress:{eaddress}");
        }

    }
}
