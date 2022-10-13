using System;
using System.Collections.Generic;
using System.Text;

namespace MetotAlistirma1
{
    public class Ogrenci
    {
        decimal toplam=0;
        decimal ort;
        public void ogrenciPuanHesapla(int[] notlar)
        { 
            for (int i = 0; i < notlar.Length; i++)
            {
                toplam += notlar[i];
            }
            ortalamaHesapla(notlar);
            if (ort < 45)
                Console.WriteLine("Ortalama değeriniz: {0} - Kaldınız!", ort);
            else
                Console.WriteLine("Ortalama değeriniz: {0} - Geçtiniz!", ort);
        }
        private decimal ortalamaHesapla(int[] notlarrr)
        {
            ort = toplam / 3;
            return ort;   //return anahtar kelimesi kendisine gelen değeri metotun dışına çıkartır.
        }
    }
}
