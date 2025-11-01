using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Product
    {
        int Proid;
        string proname;
        double proprice;
        public Product()
        {

        }
        public Product(int proid,string proname,double price)
        {
            this.Proid= proid;
            this.proname = proname;
            this.proprice = price;

        }
    }
    internal class Class12
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Kiran");
            al.Add("Uday");
            al.Add("Raj");
          //  al.Add(new Product(111,"abc",98.5));
            Console.WriteLine("Arra List Elements are");
            foreach (string s in al)
            {
                Console.WriteLine(s);
            }
            al.Sort();
            al.Reverse();
            Console.WriteLine("Arra List Elements are");
            foreach (string s in al)
            {
                Console.WriteLine(s);
            }
        }
    }
}
