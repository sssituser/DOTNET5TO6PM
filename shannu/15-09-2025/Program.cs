using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_09_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter anime name: ");
            string Anime = Console.ReadLine();
            Console.Write("Enter episodes: ");
            int Ep =Convert.ToInt32( Console.ReadLine() );


            if (Anime == "DragonBall" && Ep == 300)
                Console.WriteLine("Must Watch Anime");
            else
                Console.WriteLine("Dont watch");
            Console.ReadKey();
           
        }
    }
}
