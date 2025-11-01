using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Employ
    {
        int eid;
        string ename;
        int esal;
        public Employ()
        {

        }

        public Employ(int eid,string ename,int esal)
        {
            this.eid = eid;
            this.ename = ename;
            this.esal = esal;

        }
        public override string ToString()
        {
            return $"Emp ID : {eid}\nEmpName : {ename}\nEmpSal : {esal}";
        }
    }
    class GenExamle<T>
    {
        public void Show(T x, T y)
        {
            Console.WriteLine($" x  = {x}\ty = {y}");
        }
        
    }
    internal class Class7
    {
        
        static void Main(string[] args)
        {
            GenExamle<int> gen = new GenExamle<int>();
            gen.Show(4, 5);

            GenExamle<double> gen1 = new GenExamle<double>();
            gen1.Show(5.6, 7.8);

            GenExamle<string> gen2 = new GenExamle<string>();
            gen2.Show("abc", "def");

            GenExamle<bool> gen4 = new GenExamle<bool>();
            gen4.Show(true, false);

            GenExamle<Employ> gen5= new GenExamle<Employ>();

            gen5.Show(new Employ(111, "abc", 500000), new Employ(420, "def", 80000));


        }
    }
}
