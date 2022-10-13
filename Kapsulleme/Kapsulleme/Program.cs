using System;

namespace Kapsulleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();

            // M1.emailAdres = "elifesra@gmail.com"; (Field)

            // Kapsüllemeye genel giriş
            M1.EmailAdres = "elifesra@gmail.com";
            Console.WriteLine(M1.EmailAdres);

            // 1. Field değer ataması yapılamasın ama değer okunabilsin.
            Console.WriteLine("Müşteri Id değeri= " + M1.ID);
            // M1.ID = 10; set private olduğu için değer ataması yapamıyoz.

            M1.TcKimlikNo = "12345678910";
        }
    }
}
