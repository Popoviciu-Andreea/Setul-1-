using System;

//2. Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de
//intrare.Tratati toate cazurile posibile.
namespace Problema_2
{
    internal class Problema_2
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b=double.Parse(Console.ReadLine());
            double c=double.Parse(Console.ReadLine());
            if(a==0)
            {if(b==0)
                {if(c==0)
                    {Console.WriteLine("Ecuatia are infinit de solutii");}
                else
                    {Console.WriteLine("Ecuatia nu are solutii");}
                }
            else
                {double x=-c/b;
                Console.WriteLine($"Ecuatia are o solutie: x={x}");}
            }
            else
            {double x1=0, x2=0;
                double d = b * b - 4 * a * c;//d=delta care poate fi >0,=0,<0
                if(d<0)
                {
                    Console.WriteLine("Ecuatia nu are solutii reale");
                }
                else 
                if(d==0)
                { double x=-b/(2*a);
                    Console.WriteLine($"Ecuatia are o solutie: x={x}");
                }
           
                else
                { x1=(-b+Math.Sqrt(d))/(2*a);
                  x2=(-b-Math.Sqrt(d))/(2*a);
                Console.Write($"Solutiile ecuatiei sunt: x1={x1} si x2={x2}");
                }
            }
                
            }
        }
    }

