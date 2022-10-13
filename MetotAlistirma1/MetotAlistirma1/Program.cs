using System;

namespace MetotAlistirma1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ad soyad: ");
            string adSoyad = Console.ReadLine();
            int[] notlar = new int[3];

            for (int i = 0; i < notlar.Length; i++)
            {
                Console.Write("{0}. ders notunu girin: ", i + 1);
                notlar[i] = Convert.ToInt16(Console.ReadLine());
            }
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.ogrenciPuanHesapla(notlar);
        }
    }
}
