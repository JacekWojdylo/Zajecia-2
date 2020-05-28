using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 2;
            int s = 0;

            while (i <= 10) 
            {
                Console.WriteLine("Przebieg pętli nr {0}", i);

                s = s + j;
                j = j + 2;
                i = i + 1;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
