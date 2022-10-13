using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass
{
    internal class Musteri
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }

        public int yeniKayit(Musteri m)
        {
            Console.WriteLine("Database kayıt işlemi tamamlandı.");
            return 1;
        }

        public int kayitGuncelle(Musteri m)
        {
            Console.WriteLine("Musteri kaydı güncellendi.");
            return 1;
        }

        public int kayitSil(int id)
        {
            Console.WriteLine("Müşteri kaydı silindi");
            return 1;
        }
    }
}
