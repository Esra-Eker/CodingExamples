using System;

namespace DoWhileDongusuAlistirmalar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 1 ile X arasında bir sayı girmesini isteyin.
            //Daha sonra sistem kullanıcının girmiş olduğu 1 ile X değerleri arasında bir sayı tahmini yapsın.
            //Daha sonra kullanıcı sistemin tahmin etmiş olduğu sayıyı bulmaya çalışsın. Bulamaz ise yeniden sorsun.
            //Ne zaman kullanıcı ilgili değeri bulursa Y kadar denediniz ve sonuca ulaştınız desin.

            int tahmin;
            int sayac = 0;
            Console.Write("Tahmin oyunu için en yüksek değeri girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();
            int uretilenSayi = r.Next(1, sayi);

            do
            {
                sayac++;
                Console.Write("{0}. sayı tahmini: ",sayac);
                tahmin = Convert.ToInt32(Console.ReadLine());
                

            } while (tahmin!=uretilenSayi);
            Console.WriteLine("{0}. kere denediniz ve sonuca ulaştınız", sayac);
            
            Console.ReadLine();
        }
    }
}
