using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie13
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int x;
            int s = 0;

            x = Convert.ToInt32(Console.ReadLine());

            while (i<=x)
            {
                s += i;
                i +=2;
            }

            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
