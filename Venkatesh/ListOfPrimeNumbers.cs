using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class ListOfPrimeNumbers
    {
        public static string PrimeList(int start,int end)
        {
            string list = string.Empty;
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                if (PrimeNumbers.IsPrime(i))
                {
                    list += i + ",";
                    count++;
                }
            }
            return list.Substring(0,list.Length-1)+"."+$"\nTotal prime numbers are : {count}";    
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the start number : ");
            int start=int.Parse(Console.ReadLine());
            Console.Write("Enter the end value : ");
            int end =int.Parse(Console.ReadLine()); 
            Console.WriteLine(PrimeList(start,end));

        }
    }
}
