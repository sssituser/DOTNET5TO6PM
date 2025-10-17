using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class AllConstructors
    {
        int id;
        string name;
        string mail;
        int salary;
        static AllConstructors() //Static Constructor.
        {
            Console.WriteLine("Hi I'm static constructor ");

        }
        public AllConstructors() //Defualt constructor.
        {
            id = 1;
            name = "Nani";
            mail = "nani@example.com";
        }
        public AllConstructors(int id, string name,string mail)//Constructor with parametrs.
        {
            this.id = id;
            this.name = name;
            this.mail = mail;
        }
        public AllConstructors(AllConstructors c) // Copy COnstructor.
        {
            id= c.id;
            name= c.name;
            mail= c.mail;

        }
       
        ~AllConstructors() //Destructor
        {
            Console.WriteLine( "Hey ,I'm destructor of the object");
        }
        public  AllConstructors(int id,string name,string mail,int salary)  //Constructor Overloading.
        {
            this.id= id;
            this.name = name;
            this.mail= mail;
            this.salary = salary;
            

        }
        public void GetInfo()
        {
            Console.WriteLine($"Id : {id}\nMy Name is : {name}\nMail :{mail}\nSalary:{salary}");
        }
        static void Main(string[] args)
        {
            AllConstructors e1=new AllConstructors();
            e1.GetInfo();

            AllConstructors e2 = new AllConstructors(45, "Rohit Sharma", "shana@gmail.com", 264);
            e2.GetInfo();

            AllConstructors copy = new AllConstructors(e2);
            copy.GetInfo();
        }



    }
}
