using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExmplaes
{
    class Employ
    {
        public Employ() {
            Console.WriteLine("Hi Iam constructor without paramenter");
        }
        static Employ()
        {
            Console.WriteLine("Hi Iam Static constructor");
        }
     
      
    }
    internal class Class4
    {
        static void Main(string[] args)
        {
            Employ emp1 = new Employ();
            Employ emp2 = new Employ();
            Employ emp3 = new Employ();
            Employ emp4 = new Employ();
           
        }
    }
}
