using System;

namespace KararYapilariAlistirmalar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Not ortalaması sistemine hoşgeldiniz!");
            Console.Write("İsim ve soyisim girin: ");
            string isimSoyisim = Console.ReadLine();

            Console.Write("Not 1: ");
            decimal not1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Not 2: ");
            decimal not2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Not 3: ");
            decimal not3 = Convert.ToDecimal(Console.ReadLine());

            decimal ort = (not1 + not2 + not3) / 3;

            if (ort >= 90 && ort <= 100)
            {
                Console.WriteLine("Başarılı tebrikler!");
            }
            else if (ort>=70 && ort<90)
            {
                Console.WriteLine("İyi ile geçtiniz.");
            }
            else if (ort>=45 && ort<70)
            {
                Console.WriteLine("Orta ile geçtiniz." + ort);
            }
            else if (ort < 45)
            {
                Console.WriteLine("Kaldınız.");
            }
            else
            {
                Console.WriteLine("Notlarınızı kontrol ediniz.");
            }
        }
    }
}
