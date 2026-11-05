using System;
//16. Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri) 
namespace Problema_16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int aux;
            bool schimbat;

            // utilizarea metodei Bubble Sort (repeta pana cand nu mai exista nicio schimbare)
            do
            {
                schimbat = false;

                // Pasul 1: Comparam a cu b
                if (a > b)
                {
                    aux = a; a = b; b = aux;
                    schimbat = true;
                }

                // Pasul 2: Comparam b cu c
                if (b > c)
                {
                    aux = b; b = c; c = aux;
                    schimbat = true;
                }

                // Pasul 3: Comparam c cu d
                if (c > d)
                {
                    aux = c; c = d; d = aux;
                    schimbat = true;
                }

                // Pasul 4: Comparam d cu e
                if (d > e)
                {
                    aux = d; d = e; e = aux;
                    schimbat = true;
                }

            } while (schimbat);
            Console.Write($"{a} {b} {c} {d} {e}"); 
        }
    }
}
