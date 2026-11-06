using Microsoft.Win32;
using System;
/*20. Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 
13/30 = 0.4(3). (https://github.com/HoreaOros/ROSE2020/blob/master/2611/Program.cs) 
O fractie este neperiodica daca numitorul este de forma 2^m*5^n unde m si n sunt mai 
mari sau egale decat 0 
O fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5. 
O fractie este periodica mixta daca se divide cu 2 si/sau 5 SI se mai divide si cu alte numere 
prime diferite de 2 si 5.
*/
namespace Problema_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int nr1 = 0, nr2 = 0, x = n;
            //fractii neperioadice
            while (x % 2 == 0)
            {
                x /= 2;
                nr1++;


            }
            while (x % 5 == 0)
            {
                x /= 5;
                nr2++;
            }
            if (Math.Pow(2, nr1) * Math.Pow(5, nr2) == n)
            {
                Console.WriteLine("Fractia este neperiodica");
                double d = (double)m / n;
                Console.WriteLine(d);


            }
            else
            {
                x = n;
                //Fractii periodice simple 
                if (x % 2 != 0 && x % 5 != 0)
                {
                    Console.WriteLine("Fractia este periodica simpla");
            
                    int r = m % n;
                    int p = r;
                    Console.Write($"{m / n}.(");
                    do
                    {
                        r *= 10;
                        Console.Write(r / n);
                        r %= n;
                    }
                    while (r != p);
                    Console.WriteLine(")");
                }
                else
                {//Fractii periodice mixte

                    Console.WriteLine("Fractia este periodica mixta");

                    int y = m / n;
                    int r = m % n;

                    Console.Write($"{y}.");

                    // Afisam partea neperiodica
                    for (int i = 0; i < Math.Max(nr1, nr2); i++)
                    {
                        r *= 10;
                        Console.Write(r / n);
                        r %= n;
                    }

                    // Afisam perioada
                    int p = r;

                    Console.Write("(");

                    do
                    {
                        r *= 10;
                        Console.Write(r / n);
                        r %= n;
                    }
                    while (r != p);

                    Console.WriteLine(")");
                }
            }

            }



        }
    }




