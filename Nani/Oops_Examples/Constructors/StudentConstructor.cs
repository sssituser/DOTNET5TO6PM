using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class StudentConstructor
    {
        int studentId;
        string name;
        string branch;
        public StudentConstructor()
        {
            Console.WriteLine("Hii,This is defualt");
            studentId = 1;
            name = "Nani";
            branch = "CSE";
            Console.WriteLine("Bye");

            
        }
        public void GetInfo()
        {
            Console.WriteLine($"Student ID : {studentId}\nStudent Name : {name}\nStudent Branch : {branch}");
        }
        public StudentConstructor(int studentId,string name,string branch)
        {
            Console.WriteLine("Hii,This is parameterised Constructor");
            this.studentId = studentId;
            this.name = name;
            this.branch = branch;
            Console.WriteLine("Bye");
        }
        
        
          static void Main(string[] args)
          {
            //Objects are created for StudentConstructor.
             Console.WriteLine("=================Details About Student=================");
             
             Console.WriteLine("**obj1,Created for student and Defualt is comnstructor called.**");
              
             StudentConstructor s1= new StudentConstructor();
             s1.GetInfo();
             Console.WriteLine();

             Console.WriteLine("**obj2 is created for student and constructor with parameters is called.**");
             StudentConstructor s2= new StudentConstructor(45,"rohit sharma","cse");
             s2.GetInfo();

            //Objects are created for EmployeeConstructor.
            Console.WriteLine("\n\n");
            Console.WriteLine("===================Details About Employee================");
            Console.WriteLine("**obj1,Created for Employee and Defualt constructor is called.**");
            EmployeeConstructor e1= new EmployeeConstructor();
            e1.GetEmployeeDetails();
            Console.WriteLine();

            Console.WriteLine("**obj2 is created for employee and constructor with parameters is called.**");
            EmployeeConstructor e2 = new EmployeeConstructor(45, "Rohit Sharma", 26400);
            e2.GetEmployeeDetails();
            Console.WriteLine();
            Console.WriteLine("\n\n");

            //Objects are created for PatientConstructor.
            Console.WriteLine("===================Details About Patient================");
            Console.WriteLine("**obj1,Created for Patient and Defualt comnstructor is called.**");
            PatientConstructor p1 = new PatientConstructor();
            p1.GetPatientDetails();
            Console.WriteLine();

            Console.WriteLine("**obj2 is created for Patient and constructor with parameters is called.**");
            PatientConstructor p2 = new PatientConstructor(45, "Rohit Sharma", 10000);
            p2.GetPatientDetails();


        }
        
    }
}
