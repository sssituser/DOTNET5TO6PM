using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class AdvancedGenEx<T1, T2>
    {
        public void Show(T1 a, T2 b)
        {
            Console.WriteLine($"a = {a}\t b= {b}");
        }
    }
    internal class Class8
    {
        static void Main(string[] args)
        {
            AdvancedGenEx<int, string> gen1 = new AdvancedGenEx<int, string>();
            gen1.Show(5,"abc");
        }
    }
}
