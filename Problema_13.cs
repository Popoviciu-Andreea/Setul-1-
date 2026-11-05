using System;
//13. Determianti cati ani bisecti sunt intre anii y1 si y2. 
namespace Problema_13
{
    internal class Program
    {
        static void Main(string[] args)
        {int y1=int.Parse(Console.ReadLine());
            int y2=int.Parse(Console.ReadLine());
            int nr=0;
            if (y1 > y2)
            {
                int aux = y1;
                y1 = y2;
                y2 = aux;
            }
            for (int i=y1;i<=y2;i++)
            {
                if((i%4==0 && i%100!=0) || (i%400==0))
                {
                    nr++;
                }
            }
            Console.WriteLine($"Intre anii {y1} {y2} sunt {nr} ani bisecti ");
        }
    }
}
