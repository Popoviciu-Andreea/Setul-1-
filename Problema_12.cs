using System;
//12. Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].

namespace Problema_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            int nr = 0;
            if (n == 0)
            {
                Console.WriteLine("Nu se poate imparti la 0");
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % n == 0)
                        nr++;
                }
                Console.WriteLine($"In intervalul [{a},{b}] sunt {nr} divizibile cu {n}");
            }
        }
    }
}
