using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Product pro1= new Product();
            pro1.Getproduct(111, "mobile", 25000);
            pro1.Setproduct();


            Product pro2= new Product();
            pro2.Getproduct(112, "Tab", 30000);
            pro2.Setproduct();
        }
    }
}
