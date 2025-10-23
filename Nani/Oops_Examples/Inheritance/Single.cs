using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    
    

    
    internal class Single
    {
        protected int id;
        protected string name;
        protected string branch;

        public void GetDetails(int  id,string name,string branch)
        {
            this.id = id;
            this.name = name;
            this.branch = branch;

        }
        public void ShowDetails()
        {
            Console.WriteLine($"Id : {id}\nname : {name}\nBranch : {branch} ");
        }

    }

    class InheritSIngleB : Single
    {
        public int empId=45;
        public string empName="Shana";
        public int salary=11498;

        public void Display()
        {
            Console.WriteLine($"Emp id : {empId}\nEmp name : {empName}\nEmployee salary : {salary}");
        }
        static void Main(string[] args)
        {
             InheritSIngleB obj1= new InheritSIngleB();
            Console.WriteLine("These are belongs inherited class A methods and protected varibles");

            obj1.GetDetails(45,"Nani","CSE");
            obj1.ShowDetails();

            Console.WriteLine("These are belongs inherited class B methods");
            InheritSIngleB obj2 = new InheritSIngleB();
            obj2.Display();



        }
    }
}
