using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppADO.NETENTITY
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Class1 bl = new Class1();
            tbl_empl emp = new tbl_empl();
        Menu:
            Console.WriteLine("1.Add\n2.UPD\n3.DEL:\n4.Find\n5.FINDALL\nENter your choice : ");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.Write("Enter emolpyee ID: ");
                    emp.eid= int.Parse(Console.ReadLine());
                    Console.Write("Enter Employee Name : ");
                    emp.ename = Console.ReadLine();
                    Console.Write("Enter Employee Salary : ");
                    emp.esal= int.Parse(Console.ReadLine());
                    if (bl.AddEmployee(emp))
                    {
                        Console.WriteLine("EMployee Details ADDED..........");
                    }
                    goto Menu;
                case 2:
                    Console.Write("Enter emolpyee ID: ");
                    emp.eid = int.Parse(Console.ReadLine());
                    if (bl.DeleteEmployee(emp.eid))
                    {
                        Console.WriteLine("Employee Details Deleted........");
                    }
                    goto Menu;
                case 3:
                    Console.WriteLine("Enter emolpyee ID: ");
                    emp.eid = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Employee Name : ");
                    emp.ename = Console.ReadLine();
                    Console.WriteLine("Enter Employee Salary : ");
                    emp.esal = int.Parse(Console.ReadLine());
                    if (bl.UpdateEmployee(emp.eid))
                    {
                       

                        Console.WriteLine();
                        Console.WriteLine("EMPLOYEEE DETAILS UPDATED.......");
                    }
                    goto Menu;
                case 4:
                    Console.WriteLine("Enter emolpyee ID: ");
                    emp.eid = int.Parse(Console.ReadLine());
                    Console.WriteLine("EID\t\tEName\t\tESAL");
                    tbl_empl emp4 = bl.GetEmployee(emp.eid);

                    if(emp4!=null);
                    {
                        Console.WriteLine($"{emp.eid}\t\t{emp.ename}\t\t{emp.esal}");
                    }
                    goto Menu;
            }
        }
    }
}
