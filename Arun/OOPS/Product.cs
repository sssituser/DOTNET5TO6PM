using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    internal class Product
    {
        int proId;
        string proName;
        int proPrice;
        public void SetProduct(int proId, string proName, int proPrice)
        {
            this.proId = proId;
            this.proName = proName;
            this.proPrice = proPrice;
        }
        public void GetProduct()
        {
            Console.WriteLine($"Product Id :{proId}\nProduct Name : {proName}\nProduct Price {proPrice}");
        }
        
    }
}
