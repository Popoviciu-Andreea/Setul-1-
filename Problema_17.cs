using System;
//17.  Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 

namespace Problema_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int r=0;
            if(a<b)
            {
                int aux = a;
                a = b;
                b = aux;
            }
            int m = a, n = b;
          
             Console.Write($"Cel mai mare divizor comun a lui {a} si {b} este ");
                while(b!=0)
                {   r = a % b;
                    a = b;
                    b = r;
                 }
                Console.WriteLine(a);
            Console.Write($"Cel mai mic multiplu comun a lui {m} si {n} este {(m*n)/a} ");

        }
    }
}
