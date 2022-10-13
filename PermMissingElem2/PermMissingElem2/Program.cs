using System;

namespace PermMissingElem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 2, 3, 1, 5};
            double toplam = sayilar.Length+1;
            double toplam2 = 0;

            for (int i = 0; i < sayilar.Length ; i++)
            {
                toplam += i+1;
                toplam2 += sayilar[i];

            }
            Console.WriteLine("Eksik sayi: {0}", (toplam - toplam2));

            Console.ReadLine();
        }
    }
}
