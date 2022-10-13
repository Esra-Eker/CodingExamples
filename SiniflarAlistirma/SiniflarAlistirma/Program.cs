using System;

namespace SiniflarAlistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arac A1 = new Arac("Opel", "Corsa", 2010, 56000);
            A1.AlisFiyat = 28000;
            A1.SatisFiyat = 32000;
            A1.MaxIndirimTutar = 1500;
            // A1.Fiyat = Kapsülleme konusu......
            A1.FiyatAta(50000);
            A1.BilgileriGoruntule();
        }
    }
}
