using System;
//8. (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de 
//intrare.Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare. 
namespace Problema_8
{
    internal class Program
    {
        static void Main(string[] args)
        {double a=Convert.ToDouble(Console.ReadLine());
            double b=Convert.ToDouble(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"{a} {b}");
            
        }
    }
}
