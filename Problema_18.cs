using System;
//18. Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3 ^ 1 x 7^2.
namespace Problema_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d=2, nr=0;
            bool ok = false;
            while(n%d==0)
            { nr++;
                n = n / d;
            }
            if (nr > 0)
            { Console.Write($"{d}^{nr}");
                ok = true;
            }
            for (d = 3; d <= n/d; d += 2)
            {
                nr = 0;
                while (n % d == 0)
                { 
                    nr++;
                    n = n / d;
                }
                if (nr > 0)
                {if(ok)
                        Console.Write($"*");
                    Console.Write($"{d}^{nr}");
                    ok = true;
                }
            }
            if (n > 1)
            {
                if (ok)
               Console.Write($"*");
                Console.Write($"{n}^{1}");
            }

        }
    }
}
