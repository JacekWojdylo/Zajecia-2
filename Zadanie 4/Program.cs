using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Podaj liczbę a:");
            a = Convert.ToDouble(Console.ReadLine());

            double b;
            Console.WriteLine("Podaj liczbą b:");
            b = Convert.ToDouble(Console.ReadLine());

            double c;
            Console.WriteLine("Podaj liczbę c:");
            c = Convert.ToDouble(Console.ReadLine());

            double max;
            double min;

            if (a > b)
            {
                max = a;
                min = b;
            }
            else
            {
                max = b;
                min = a;
            }
            if (c < min)
            {
                Console.WriteLine("{0}, {1}, {2}", c, min, max);
            }
            else if (c < max)
            {
                Console.WriteLine("{0}, {1}, {2}", min , c , max) ;
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", min , max , c);
            }
            

            Console.ReadKey();
        }
    }
}
