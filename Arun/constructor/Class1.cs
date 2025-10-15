using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExmplaes
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(); 
            Console.WriteLine(p1.ProdDes);
            p1.GetData();
            Product p2= new Product(123,"lkh",500);
            p2.GetData();
        }
    }
}
