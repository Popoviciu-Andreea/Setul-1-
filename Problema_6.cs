using System;
//6. Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.
namespace Problema_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b=double.Parse(Console.ReadLine());
            double c=double.Parse(Console.ReadLine());
            if(a+b>c&&a+c>b&&b+c>a)
            {
                Console.WriteLine($"Numerele {a} {b} {c} sunt lungimile laturilor unui triunghi");
            }
            else
            {
                Console.WriteLine($"Numerele {a} {b} {c} nu  sunt lungimile laturilor unui triunghi");
            }
        }
    }
}
