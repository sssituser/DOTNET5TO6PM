using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class Gen<T>
    {
        public void ShowInfo(T t)
        {
            Console.WriteLine($" T is  {t}");
        }
    }

    internal class FileName
    {
        static void Main(string[] args)
        {
            Gen<int> gen = new Gen<int>();
            gen.ShowInfo(4);


            Gen<string> gen1 = new Gen<string>();
            gen1.ShowInfo("Shannu");


            Gen<float> gen2 = new Gen<float>();
            gen2.ShowInfo(4.8f);

            Gen<double> gen3 = new Gen<double>();
            gen3.ShowInfo(4.323);

            Gen<bool> gen4 = new Gen<bool>();
            gen4.ShowInfo(true);

        }
    }
}
