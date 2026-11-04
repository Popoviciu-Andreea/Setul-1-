using System;
//10.Test de primalitate: determinati daca un numar n este prim. 
namespace Problema_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n<2)
                Console.WriteLine($"Numarul {n} nu este prim");
            else
            {

                bool ok = true;
                for(int d=2; d * d <= n; d++)
                {
                    if(n % d == 0)
                    {
                        ok = false;
                        break;
                    }
                }
                if(ok)
                    Console.WriteLine($"Numarul {n} este prim");
                else
                    Console.WriteLine($"Numarul {n} nu este prim");
            }
        }
    }
}
