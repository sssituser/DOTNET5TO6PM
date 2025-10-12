using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class PrimeNumbers
    {
        public static bool IsPrime(int num)
        {
            
            if (num <= 0)
            {
                //Console.WriteLine("Enter Natural number to check whether it is prime or not .. ");
                return false;
            }
            else if (num == 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                        
                    }
                    
                   
                    
                }
                return true;
            }
            
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a Natural Number : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(num));
        }
    }   
}
