using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie15
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int n;

            Console.WriteLine("Podaj liczbę naturalą n>1");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            { 
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
