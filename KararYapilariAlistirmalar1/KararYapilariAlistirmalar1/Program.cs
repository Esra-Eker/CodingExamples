using System;
using System.Threading.Channels;

namespace KararYapilariAlistirmalar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı kodunu giriniz: ");
            string kullaniciKodu = Console.ReadLine().ToUpper();

            if (kullaniciKodu == "ABC" || kullaniciKodu == "123" || kullaniciKodu == "236" || kullaniciKodu == "CMK")
            {
                Console.WriteLine("Kullanıcı girişiniz başarılı.");
            }
            else if(kullaniciKodu == "HHH" || kullaniciKodu == "BBB" || kullaniciKodu=="MMM")
            {
                Console.WriteLine("Kullanıcı girişiniz kilitlenmiştir.");
            }
            else
            {
                Console.WriteLine("Hatalı kullanıcı kodu");
            }
            Console.ReadLine();
        }
    }
} 
