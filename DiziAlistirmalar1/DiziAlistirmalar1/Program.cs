using System;

namespace DiziAlistirmalar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[20];
            Random rnd = new Random();

            int sayac = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(1,10);
                Console.WriteLine(dizi[i]);
                if (dizi[i] == 4)
                    sayac++;
            }
            Console.WriteLine("Dizide {0} tane 4 sayısı vardır.", sayac);

            Console.ReadLine();
        }
    }
}
