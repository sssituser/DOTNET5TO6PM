using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class CalenderNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String : ");
            String month = Console.ReadLine().Trim().ToLower();

            int num = 0;

           
            string[] months = new string[12] { "janUARY", "february", "marCh", "april", "may", "june", "july", "augUST", "sepTEMBER", "octobER", "novemBER", "december" };

            String[] MONTHS = new string[months.Length];

            for (int i = 0; i < months.Length; i++)
            {
                MONTHS[i] = months[i].ToLower().Trim();
            }
                for (int i = 0; i < MONTHS.Length; i++)
                {
                    if (MONTHS[i].Contains(month))
                    {
                        num = i + 1; ;

                    }


                }
                Console.WriteLine($"{num}");
            }
        }
    
}
