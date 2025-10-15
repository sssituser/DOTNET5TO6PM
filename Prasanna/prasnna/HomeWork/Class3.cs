using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Bank b1= new Bank();
            b1.GetData();
            Console.WriteLine("\n\n");

            Bank b2= new Bank(4204,"Subbu","sbin089",78965);
            b2.GetData();
            Console.WriteLine("\n\n");

            Bank b3= new Bank(4205,"Lucky","sbin067",67895);
            b3.GetData();
            Console.WriteLine("\n\n");

            Bank b4= new Bank(4206,"Honey","sbin048",98345);
            b4.GetData();
            Console.WriteLine("\n\n");

        }
    }
}
