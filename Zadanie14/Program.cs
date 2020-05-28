using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie14
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 2;
            int s = -10;

            while (i <= 10)
            {
                s += j;
                j += 2;
                i += 1;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
