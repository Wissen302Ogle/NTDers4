using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            int toplam = 0;
            int biröncekiSayi = 0;
            while (true)
            {
                Console.Write("Bir sayı giriniz =");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == 0)
                    break;
                if (sayi == biröncekiSayi)
                {
                    Console.WriteLine("Farklı bir sayı girin..");
                    continue;
                }
                toplam += sayi;
                Console.WriteLine("Toplam =" + toplam);
                biröncekiSayi = sayi;
            }
            Console.Write("Döngü bitti..");
            Console.ReadKey();

        }
    }
}
