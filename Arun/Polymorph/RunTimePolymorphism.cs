using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Emply
    {
        int Eid;
        String Ename;
        int Esal;

        public Emply()
        {

        }

        public Emply(int Eid,String Ename,int Esal)
        {
            this.Eid = Eid;
            this.Ename = Ename;
            this.Esal = Esal;
        }

        public override string ToString()
        {
            return $"EmpId : {Eid}\nEmpName : {Ename}\nEmpSal : {Esal}";
        }

        

    }
    
    internal class RunTimePolymorphism
    {
        static void Main(string[] args)
        {
            Emply emply = new Emply(111, "Venkat", 5000);
            Console.WriteLine(emply.ToString());
        }


    }
}
