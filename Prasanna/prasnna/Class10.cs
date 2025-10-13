using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodsexamples
{
    internal class Class10
    {
        public static int GetLuckyNumber(string dob) //"19-Oct-2024"
        {

            string[] result = dob.Split('-');
            int date = int.Parse(result[0]);
            int month = ConvertMonthTextToNum(result[1]);
            int year = int.Parse(result[2]);
            int sum = date + month + year;
            while (sum > 9)
            {
                sum = DigitSum(sum);
            }
            return sum;



        }

        private static int DigitSum(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        private static int ConvertMonthTextToNum(string monthText)
        {
            monthText = monthText.Trim().ToLower();
            string[] months = { "jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec" };
            for (int i = 0; i < months.Length; i++)
            {
                if (monthText.Contains(months[i]))
                {
                    return i + 1;
                }
            }
            return 0;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter Date of Birth:Format(12-OCT-2345) :");
            string dob = Console.ReadLine();
            Console.WriteLine($"Your Lucky Number is : {GetLuckyNumber(dob)}");
        }
    }
}
