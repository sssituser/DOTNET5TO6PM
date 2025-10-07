using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehodsExample
{
    internal class Class5
    {
        public static string AdamList(int start,int end)
        {
            string res = string.Empty;
            for (int i = start; i <= end; i++) {
                if (Class4.IsAdam(i))
                {
                    res += i + ",";
                }
            }
            return $"Adam numbers list : { res.Substring(0, res.Length - 1) + "."}";
        }
        static void Main(string[] args)
        {
            Console.Write("Enter start value : ");
            int start = int.Parse(Console.ReadLine());  
            Console.Write("Enter end value : ");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine(AdamList(start,end));
        }
    }
}
