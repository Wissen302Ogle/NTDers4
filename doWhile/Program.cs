using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Random rnd = new Random();
            do
            {
                sayi = rnd.Next(1, 101);
                Console.WriteLine("Çıkan Sayı :" + sayi);
            } while (sayi != 50);
            Console.ReadKey();
        }
    }
}
