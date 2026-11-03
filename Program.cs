using System;

//1. Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0,
//unde a si b sunt date de intrare
namespace Problema_1
{
    internal class Program
    {
        static void Main(string[] args)
        {double a=double.Parse(Console.ReadLine());
            double b=double.Parse(Console.ReadLine());
            if (a==0)
            {
                if (b==0)
                {
                    Console.WriteLine("Ecuatia are o infinitate  de solutii.");
                }
                else
                {
                    Console.WriteLine("Ecuatia nu are solutii.");
                }
            }
            else
            {
                double x=-b/a;
                Console.WriteLine($"Solutia ecuatiei este: x={x}");
            }
        }
    }
}
