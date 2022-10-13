using System;
using System.Collections.Generic;

namespace BolumSonuOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.musteriID = 1;
            M1.isim = "Esra";
            M1.soyisim = "hehhe";
            M1.emailAdres = "elifesra@gmail.com";
            M1.sifre = "asdf";
            M1.kullaniciAdi = "esraek";

            Musteri.MusteriEkle(M1);

            Musteri M2 = new Musteri()
            {
                musteriID = 2,
                isim = "selin",
                soyisim = "yılmaz",
                emailAdres = "selin.yilmaz@gmail.com",
                kullaniciAdi = "selinn",
                sifre="454"
            };

            Musteri.MusteriEkle(M2);

            Musteri M3 = new Musteri();
            M3.musteriID = 1;
            M3.isim = "Esra";
            M3.soyisim = "hehhe";
            M3.emailAdres = "elifesra@gmail.com";
            M3.sifre = "asdf";
            M3.kullaniciAdi = "esraek";

            Musteri.MusteriEkle(M3);

        }
    }
}
