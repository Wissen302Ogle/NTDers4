using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            int toplam = 0;
            while(sayi<=100)
            {
                if(sayi%2==0)
                {
                    toplam = toplam + sayi;
                    Console.WriteLine(sayi);
                }
                sayi++;
            }
            Console.WriteLine();
            Console.WriteLine("Toplam = "+toplam);
            Console.ReadKey();
                
        }
    }
}
