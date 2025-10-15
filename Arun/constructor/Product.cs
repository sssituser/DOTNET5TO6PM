using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExmplaes
{
    internal class Product
    {
        int ProId;
        string ProductName;
        int ProductPrice;
        public string ProdDes { get; private set; }
        public Product() //constructor with out parameter
        {
            Console.WriteLine("Hi Iam Constructor with out Parmeter start");
            ProId = 111;
            ProductName = "abc";
            ProductPrice = 100;
            Console.WriteLine("Hi Im Constructor with out parameter ending");
        }
        public Product(int ProId,string ProductName , int ProductPrice=1000)
        {
            Console.WriteLine("Hi Im constructor with Paramter started");
            this.ProId = ProId;
            this.ProductName = ProductName;
            this.ProductPrice = ProductPrice;
            Console.WriteLine("Hi Iam Constructor with paramters endig");
        }





        public void GetData()
        {
            Console.WriteLine($"Product ID :{ProId}\nProduct Name:{ProductName}" +
                $"\nProduct Price : {ProductPrice}");
        }

    }
}
