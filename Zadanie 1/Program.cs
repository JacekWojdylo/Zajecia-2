using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double litr = (132 * 6.5) / 100;
            double koszt = litr * 3.29;

            Console.WriteLine(koszt);
            Console.ReadKey();
        }
    }
}
