using System;
using System.IO;
//21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?".
namespace Problema_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 1, d = 1024, m, x;

            while (s < d)
            {
                m = (s + d + 1) / 2;

                Console.WriteLine("Numarul este mai mare sau egal decat " + m + "? (1 = DA, 0 = NU)");
                x = int.Parse(Console.ReadLine());

                if (x == 1)
                    s = m;
                else
                    d = m - 1;
            }

            Console.WriteLine("Numarul ghicit este: " + s);

        }
    }
}
