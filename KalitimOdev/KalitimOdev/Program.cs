using System;

namespace KalitimOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar B1 = new Bilgisayar();
            // B1.id = 1; // girmek istemiyorum, uygulamanın bana bu alanı set edilebilir şekilde bırakmasını da istemiyorum.
            B1.marka = "Lenovo";
            B1.model = "Legion";
            B1.islemci = "i7";
            B1.alisFiyat = 5000;
            B1.satisFiyat = 6000;
            B1.kampanyaFiyat = 3000;
            B1.barkod = "123456789";

            sanalDatabase.yeniUrunEkle(B1);

            Bilgisayar B2 = new Bilgisayar();
            // B1.id = 1; // girmek istemiyorum, uygulamanın bana bu alanı set edilebilir şekilde bırakmasını da istemiyorum.
            B2.marka = "Lenovo";
            B2.model = "Legion";
            B2.islemci = "i7";
            B2.alisFiyat = 5000;
            B2.satisFiyat = 6000;
            B2.kampanyaFiyat = 3000;
            B2.barkod = "123456789";

            sanalDatabase.yeniUrunEkle(B2);
        }
    }
}
