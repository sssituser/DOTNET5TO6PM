using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConcept
{
    internal class Class20
    {
        static void Main(string[] args)
        {
            Console.Write("Enter month : ");
            string month = Console.ReadLine();


            month = month.ToLower();


            string[] months = {"jan","feb","mar","apr","may","jun","jul","aug","sep","oct","nov","dec" };
           
            int monthNumber = 0;
            for (int i = 0; i < months.Length; i++)
            {
               if(month.Contains(months[i]))
                {
                    monthNumber = 1 + i;
                }
            }

            Console.WriteLine($"{month} Index is {monthNumber}");

        }
    }
}
