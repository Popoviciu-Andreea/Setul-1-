using System;
//9. Afisati toti divizorii numarului n. 
namespace Problema_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
           if (n == 0)
                Console.WriteLine($"Numarul nu are divizori");
            else
            { Console.Write($"Divizorii lui {n} sunt: ");
                for(int d=1;d*d<=n;d++)
                {if(n%d==0)
                    {Console.Write ($"{d} ");
                    if(n/d!=d)
                        Console.Write($"{n/d} ");
                    }
                }
            }
        }

        
        
    }
}
