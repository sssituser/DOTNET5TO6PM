using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class PROGRAM5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eNTER ANY nUMBER : ");
            int Num = int.Parse(Console.ReadLine());
            char k = '*'; 
            for (int i = 1; i <= Num; i++) {
                for (int j = 1; j <=i; j++) {
                    Console.Write($"{k}\t" );
                }
                Console.WriteLine();
            }
            
            for (int i = Num-1; i >= 1; i--) {
                for (int j = 1; j <= i; j++) { 
                    Console.Write($"{k}\t");
                }
                Console.WriteLine();
            }
            

        }
    }
}
