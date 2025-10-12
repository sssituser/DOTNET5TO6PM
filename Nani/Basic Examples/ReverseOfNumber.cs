using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class ReverseOfNumber
    {
       
            static void Main(string[] args)
            {
                //Reverse Number mathlab Getting a nummber in reverse order Like 123==>321, 456==>654 etc.
                Console.Write("Enter a Number : ");
                int num = Convert.ToInt32(Console.ReadLine());
                int reverseNumber = 0;


                do//456
                {
                    int digit = num % 10;
                    reverseNumber = (reverseNumber * 10) + digit;
                    num = num / 10;



                } while (num > 0);
                Console.WriteLine("The Reverse Number is : " + reverseNumber);
            }
        
    }
}
