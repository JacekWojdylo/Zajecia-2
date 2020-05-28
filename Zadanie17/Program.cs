using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie17
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
            int R = a % b;

            while (R != 0)
            {
                a = b;
                b = R;

            }

            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
