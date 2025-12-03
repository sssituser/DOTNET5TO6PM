using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppADO.NETENTITY
{
    internal class Class1
    {
        sssdbEntities1 sb = new sssdbEntities1();
        tbl_empl emp = new tbl_empl();

        public bool AddEmployee(tbl_empl emp)
        {
            sb.tbl_empl.Add(emp);
            return sb.SaveChanges() ==1;
        }
        public bool DeleteEmployee(int empid)
        {
           tbl_empl emp1 = sb.tbl_empl.Find(empid);
            sb.tbl_empl.Remove(emp1);
            return sb.SaveChanges() ==1;
        }
        public bool UpdateEmployee(int empid)
        {
            tbl_empl emp2= sb.tbl_empl.Find(empid);
            emp2.ename = emp.ename;
            emp2.esal = emp.esal;
            
            return sb.SaveChanges()==1;
        }
        public tbl_empl GetEmployee(int empid)
        {
            tbl_empl employee= sb.tbl_empl.Find(empid);
            return employee;

        }
        public List<tbl_empl> GetEmployeeList()
        {
            return sb.tbl_empl.ToList();
        }
    }
}
