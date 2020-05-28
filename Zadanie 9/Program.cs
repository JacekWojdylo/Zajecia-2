using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj stałą:");
            int a = Convert.ToInt32(Console.ReadLine());
            int j = 2;
            int s = 0;

            for (int i=1; i<= a; i++)
            {
                Console.WriteLine("Przebieg pętli nr {0}", i);

                s = s + j;
                j = j + 2;
                
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
