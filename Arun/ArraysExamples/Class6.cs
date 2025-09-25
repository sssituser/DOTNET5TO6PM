using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConcept
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];
            int[] sub1 = new int[3];
            int[] sub2 = new int[3];
            int[] sub3 = new int[3];
            int[] total = new int[3];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Enter Student Name: ");
                names[i] =Console.ReadLine();
                Console.Write("Enter Sub1 Marks : ");
                sub1[i] = int.Parse(Console.ReadLine());
                Console.Write("Enter Sub2 Marks : ");
                sub2[i] = int.Parse(Console.ReadLine());
                Console.Write("Enter Sub3 Marks : ");
                sub3[i] = int.Parse(Console.ReadLine());
                total[i] = sub1[i]+sub2[i]+sub3[i];

            }
            Console.WriteLine("Students Result");
            Console.WriteLine("Name\tSub1\tSub2\tSub3\tTotal");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]}\t{sub1[i]}\t{sub2[i]}\t{sub3[i]}\t{total[i]}");
            }



        }
    }
}
