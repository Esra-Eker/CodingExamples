using System;

namespace WhileDongusuAlistirmalar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sistemin çalışma zamanında oluşturduğu 1 ile 10 arasındaki bir değeri kullanıcının tahmin etmesini isteyecek bir uygulama yaz.

            int uretilenSayi = 0;
            Random rnd = new Random();
            uretilenSayi = rnd.Next(1,10);
            int sayac = 0;

            while (true)
            {
                Console.Write("Bi sayı tahmin edin: ");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                sayac++;
                if (tahmin == uretilenSayi)
                {
                    Console.WriteLine("Tebrikler, doğru tahmin!");
                    break;
                }
         
            }
            Console.WriteLine("{0}. defada doğru tahmin ettiniz..", sayac);
            Console.ReadLine();

        }
    }
}
