using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{

    class Ccenter
    {
        public void Show()
        {
            Console.WriteLine("Hi this is show method from Parent class");
        }
        public virtual void Price()
        {
            Console.WriteLine("Hi Iam Price method from Parent class : 250");
        }
    }
    class Crestaurent :Ccenter
    {
        public void Display()
        {
            Console.WriteLine("Hi iam Display method from Child class");
        }
        public override void Price()
        {
            Console.WriteLine("Hi Iam price mehod from child class and the price 400");
        }

    }


    internal class Class2
    {
        static void Main(string[] args)
        {
            Ccenter c;
            c = new Crestaurent();
            c.Price();
            c=new Ccenter();
            c.Price();



        }
    }
}
