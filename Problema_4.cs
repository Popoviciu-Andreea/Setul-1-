using System;
//4. Detreminati daca un an y este an bisect.

namespace Problema_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if((n % 4 == 0 && n % 100 != 0) || (n % 400 == 0))
            {
                Console.WriteLine("Anul este bisect");
            }
            else
            {
                Console.WriteLine("Anul nu este bisect");
            }
        }
    }
}
