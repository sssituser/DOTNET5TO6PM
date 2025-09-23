using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class15
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter a number:");
           int number = Convert.ToInt32(Console.ReadLine());
           int copy = number; 
           int ams = 0;
           int count = 0;
            while (number >0) 
            {
                count++; 
                number = number / 10; 

            }
            number = copy; //1634
            while (number > 0) 
            {
                int ld = number % 10; 
                int poweVal = 1;
                for(int i = 0; i < count; i++) 
                {
                    poweVal = poweVal* ld;
                }
                ams = ams + poweVal; 
                number = number / 10; 
            }
            if(copy==ams)
            {
                Console.WriteLine("Given number is Armstrong");
            }
            else
            {
                Console.WriteLine("Given number is not an Armstrong number");
            }   
                

        }
    }
}
