using System;
//5. Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.
namespace Probelma_5
{
    internal class Program
    {
        static void Main(string[] args)
        {   int n=int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int nr= 1;
            while(nr<k)
            {
                n = n / 10;
                nr++;
                    
            }
            Console.WriteLine(n%10);
        }
    }
}
