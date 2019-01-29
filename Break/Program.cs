using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break
{
    class Program
    {
        static void Main(string[] args)
        {
            char karakter;
            do
            {
                Console.Write("Karakter giriniz :");
                karakter = Convert.ToChar(Console.ReadLine());
                if (karakter == 'q' || karakter=='Q')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Döngüye devam..");
                }
            } while (true);
            Console.WriteLine("Döngü bitti..");
            Console.ReadKey();
        }
    }
}
