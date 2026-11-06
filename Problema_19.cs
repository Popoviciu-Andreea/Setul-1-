using System;
using System.ComponentModel;
//19. Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.
namespace Problema_19
{
    internal class Program
    {
        static void Main(string[] args)
        {int n=int.Parse(Console.ReadLine());
            int x = n % 10;
            n = n / 10;

            int y = -1;
            bool ok = true;

            while (n > 0)
            {
                int c = n % 10;

                if (c != x)
                {
                    if (y == -1)
                        y = c;
                    else
                    if (c != y)
                        ok = false;
                }

                n = n / 10;
            }

            if (ok && y != -1)
                Console.WriteLine("Numarul este format doar cu 2 cifre care se pot repeta");
            else
                Console.WriteLine("Numarul nu este format doar cu 2 cifre care se pot repeta");



        }
    }
}
