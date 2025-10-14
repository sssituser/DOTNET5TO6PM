using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int[] Array = {50,40,80,20};
                foreach (int i in Array)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
                for(int i = 0;i<Array.Length;i++)
                {
                    for(int j = i+1;j<Array.Length;j++)
                    {
                    if (Array[i] > Array[j])
                    {
                        int copy = Array[i];
                        Array[i] = Array[j];
                        Array[j] = copy;
                    }
                    }
                }
                Console.WriteLine();
            foreach (int i in Array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
