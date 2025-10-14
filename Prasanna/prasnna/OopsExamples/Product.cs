using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    internal class Product
    {
        int productId;
        string productName;
        int productCost;
        public  void Getproduct(int productId,string productname,int productCost)
        {
            this.productId=productId;
            this.productName=productname;
            this.productCost=productCost;

        }
        public void Setproduct()
        {
            Console.WriteLine($"PoductId:{productId}\nProductName:{productName}\nProductCost:{productCost}");
        }

    }
}
