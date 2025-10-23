using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    interface IFirstInterface
    {
        void StudentDisplay();

       
    }
    interface ISecondInterface
    {
        void EmployeeDisplay();
    }

    internal class MultipleInheritances : IFirstInterface , ISecondInterface
    {
        public void StudentDisplay()
        {
            Console.WriteLine("Hii,I'm from interface 1 method implemented in child class");
        }
        public void EmployeeDisplay()
        {
            Console.WriteLine( "Hii,I'm from interface 2 method implemented in child class");
        }
        static void Main(string[] args)
        {
             MultipleInheritances multiple = new MultipleInheritances();
            multiple.StudentDisplay();
            multiple.EmployeeDisplay();

        }
    }
}
