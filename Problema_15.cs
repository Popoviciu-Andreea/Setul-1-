using System;
//15. Se dau 3 numere. Sa se afiseze in ordine crescatoare.
namespace Problema_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double aux;
            if (a > b) { aux = a; a = b; b = aux; }
            if (b > c) { aux = b; b = c; c = aux; }
            if (a > b) { aux = a; a = b; b = aux; }
            Console.WriteLine($"{a} {b} {c}");
        }
    }
}
