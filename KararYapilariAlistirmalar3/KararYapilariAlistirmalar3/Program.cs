using System;

namespace KararYapilariAlistirmalar3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı Kodu: ");
            string kullaniciKodu = Console.ReadLine().ToUpper();

            switch (kullaniciKodu)
            {
                case "AA":
                case "BB":
                case "CC":
                    Console.WriteLine("Admin yetkisine sahipsiniz.");
                    break;
                case "DD":
                    Console.WriteLine("Güçlü kullanıcı yetkisine sahipsiniz.");
                    break;
                case "FF":
                case "EE":
                case "GG":
                    Console.WriteLine("Standart kullanıcı yetkisine sahipsiniz.");
                    break;
                default:
                    Console.WriteLine("Hatalı kullanıcı kodu");
                    break;
            }

        }
    }
}
