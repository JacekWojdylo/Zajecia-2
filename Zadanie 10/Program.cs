using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_10
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int j = 2;
            int s = 0;

            for (int i = 1; i <=30; i++)
            {
                Console.WriteLine("Dni odkładania {0}", i);

                s = s + j;
                j = j + 2;
            }
            Console.WriteLine("John odłożył " + s + "zł");
            Console.ReadKey();
        }
    }
}
