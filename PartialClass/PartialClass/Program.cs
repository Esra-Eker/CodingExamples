using System;

namespace PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.id = 1;
            M1.isim = "esra";
            M1.soyisim = "eker";
            M1.emailAdres = "esra.eker@gmail.com";

            int sonuc = M1.yeniKayit(M1);
            if (sonuc > 0)
            {
                Console.WriteLine("Database yeni kayıt eklendii.. ");
            }

            Ogrenci O1 = new Ogrenci();
            O1.id = 1;
            O1.yeniKayit(O1);
        }
    }
}
