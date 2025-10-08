using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class AmstrongNumbersList
    {
        public static string AmstrongList(int start , int end)
        {
            string res = string.Empty;
            for (int i=start;i<=end;i++)
            {
                
                if(AmstrongNumberCheck.IsAmstrong(i))
                {
                    res += i + ",";
                }
                
            }
            return res.Substring(0, res.Length - 1) + ".";
        }
        static void Main(string[] args)
        {
            Console.Write("Enter starting  value : ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter the end value : ");
            int end = int.Parse(Console.ReadLine());    
            Console.WriteLine(AmstrongList(start, end));
        }
    }
}
