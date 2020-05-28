using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.Write("Podaj liczbę całkowitą a: ");
            a = Convert.ToDouble(Console.ReadLine());
            double b;
            Console.Write("Podaj liczbę całkowitą b: ");
            b = Convert.ToDouble(Console.ReadLine());
            double c;
            Console.Write("Podaj liczbę całkowitą c: ");
            c = Convert.ToDouble(Console.ReadLine());
            double max;

            if (a>b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            if (c>max)
            {
                max = c;
            }
            Console.WriteLine("Liczba największa ma wartość " + max);
            Console.ReadKey();    

        }
    }
}
