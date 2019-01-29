using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fordongusu
{
    class Program
    {
        static void Main(string[] args)
        {   //Kullanıcının girdiği satır ve sütun sayısı kadar * koyan program

            int satir, sutun;
            Console.Write("Satır sayısı giriniz: ");
            satir = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sütun sayısı giriniz: ");
            sutun = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= satir; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= sutun; j++)
                {
                    Console.Write("* ");
                }
            }
            Console.ReadKey();
        }
    }
}
