using System;

namespace DoWhileDongusuAlistirmalar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıyı do while içerisine alın ve kullanıcı adı ve password sorun.
            //Kullanıcı adı: demo
            //Şifre: demo
            //Eğer kullanıcı bu değerleri bilirse döngüden çıkın ve başarılı yazın. Eğer yanlış giriş yapıyorsa do while ile ilgili değerleri sormaya devam edin.

            int sayac = 0;
            string ad;
            string sifre;

            do
            {
                //sayac ile kontrol etmemiz önemli çünkü do while içerisinde herhangi bir if koşulu ile şartlarımızı kontrol etmedik. while (şart) bloğu içerisinde kontrollerimizi yaptığımız için değerin hatalı veya doğru olduğunu sayac adındaki bu değişken ile kontrol ettik.
                if (sayac > 0)
                {
                    Console.WriteLine("Kullanıcı veya şifreden biri hatalı..");
                }
                Console.Write("Kullanıcı adı: ");
                ad = Console.ReadLine();
                Console.Write("Şifre: ");
                sifre = Console.ReadLine();
                       
                sayac++;

            } while (ad.ToLower() != "demo" || sifre.ToLower() != "demo"); //if yazarak da kontrol ettirebilirdim.

            Console.WriteLine("Başarılı giriş yaptınız!");
            Console.ReadLine();
        }
    }
}
