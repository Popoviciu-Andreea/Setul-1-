using System;
//7. (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.
namespace Problema_7
{
    internal class Program
    {
        static void Main(string[] args)
        {double a=double.Parse(Console.ReadLine());
            double b=double.Parse(Console.ReadLine());
            double aux=a;
            a = b;
            b = aux;
            Console.WriteLine($"{a} {b}");

        }
    }
}
