using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            int[,] a = new int[ 2, 3];
            Console.WriteLine("enter array elements");
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<3;j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("array elements are");
            for (int i = 0; i < 2; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.Write(a[i,j]+"\t");
                }
                Console.WriteLine("\n\n");
            }
            Console.WriteLine("displaying transpose of array  elements");
            for(int i = 0;i<3;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.Write(a[j, i] + "\t");
                }
                Console.WriteLine("\n\n");
            }
            
        }
    }
}
