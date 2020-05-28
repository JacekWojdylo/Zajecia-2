using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj stałą:");
            int a = Convert.ToInt32(Console.ReadLine());
            int s = 1;

            for(int i=1; i<=a; i++)
            {
                Console.WriteLine("Przebieg pętli nr {0}", i);

                s = s + 1;
            }

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
