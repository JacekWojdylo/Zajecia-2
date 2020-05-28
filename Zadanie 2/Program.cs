using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj liczbę całkowitą a: ");
            a = Convert.ToInt32(Console.ReadLine());
            int b;
            Console.Write("Podaj liczbę całkowitą b: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a % b == 0)
            {
                Console.WriteLine("Liczba a jest podzielna przez b");
            }
            else
            {
                Console.WriteLine("Liczba a nie jest podzielna przez b");
            }

            Console.ReadKey();
        }
    }
}
