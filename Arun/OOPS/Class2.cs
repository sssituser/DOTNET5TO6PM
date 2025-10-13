using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.SetProduct(234, "abc", 6000);
            p1.GetProduct();
        }
    }
}
