using System;
//3. Determinati daca n se divide cu k, unde n si k sunt date de intrare
namespace Problema_3
{
    internal class Problema_3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            //un numar n se divide cu k daca restul impartirii lui n la k este 0
            if (k == 0)
                Console.WriteLine("Impartirea la 0 nu este definita");
            else
            {
                if (n % k == 0)
                    Console.WriteLine($"Numarul {n} se divide cu {k}");
                else
                    Console.WriteLine($"Numarul {n} nu se divide cu {k}");
            }

        }
    }
}
