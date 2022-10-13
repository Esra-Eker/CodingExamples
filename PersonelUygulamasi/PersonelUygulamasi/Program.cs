using System;

namespace PersonelUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel P1 = new Personel();  // bu çalıştığında önce static yapıcı metot çalışacak, sonra standart yapıcı metot çalışıcak. çünkü ben standart yapıcı metotumun içinde static yapıcı metotun içinde değer atadığım bi şeyi kullanmak isteyebilirim.
            P1.Isim = "esra";
            P1.Soyisim = "eker";
            P1.EmailAdres = "elif.esra";
            P1.Cinsiyet = 1234567890; // kadın
            
            Personel P2 = new Personel();
            P2.Isim = "esra";
            P2.Soyisim = "eker";
            P2.EmailAdres = "elif.esra";
            P2.Cinsiyet = 1234567890;

            Helper.emailGonder("ik@firmam.com", "Yeni Personel Bilgilendirme", P1.Isim + P1.Soyisim);  // static metot
            Helper.emailGonder("ik@firmam.com", "Yeni Personel Bilgilendirme", P1.Isim + P1.Soyisim);
        }
    }
}
