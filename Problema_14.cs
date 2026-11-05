using System;
//14. Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 
namespace Problema_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = n, ogl = 0;
            while(m>0)
            {
                ogl = ogl * 10 + m % 10;
                m = m / 10;
            }
            if(ogl==n)
            {
                Console.WriteLine($"Numarul {n} este palindrom");
            }
            else
            {
                Console.WriteLine($"Numarul {n} nu este palindrom");
            }
        }
    }
}
