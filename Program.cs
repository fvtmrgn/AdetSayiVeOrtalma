using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiledongusu01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç adet sayı girmek istiyorsunuz? ");
            int adet = Convert.ToInt32(Console.ReadLine());
            double toplam = 0;

            for (int i = 0; i < adet; i++)
            {
                Console.Write($"{i + 1}. sayıyı girin: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
            }

            double ortalama = toplam / adet;
            Console.WriteLine("Girdiğiniz sayıların toplamı:" + toplam);
            Console.WriteLine("Girdiğiniz sayıların ortalaması:" + ortalama);
        }
    }
}
