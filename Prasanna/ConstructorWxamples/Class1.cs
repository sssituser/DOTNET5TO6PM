using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorWxamples
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Employee e1= new Employee();
            e1.GetData();

            Employee e2= new Employee(111,"siva",60000);
            e2.GetData();
        }
    }
}
