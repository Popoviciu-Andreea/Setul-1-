using System;
using System.ComponentModel;
//11. Afisati in ordine inversa cifrele unui numar n.
namespace Problema_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            do
            {
                Console.Write($"{n % 10} ");
                n = n / 10;
            } while (n > 0);
        }
    }
}
