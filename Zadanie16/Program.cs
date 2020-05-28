using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Podaj a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = Convert.ToInt32(Console.ReadLine());

            while (a!=b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }       
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
