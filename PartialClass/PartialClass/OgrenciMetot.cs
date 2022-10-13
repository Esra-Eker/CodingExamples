using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass
{
    internal partial class Ogrenci
    {
        public int yeniKayit(Ogrenci o)
        {
            Console.WriteLine("Yeni kayıt işlemi başarılı");
            return 1;
        }

        public int kayitGuncelle(Ogrenci o)
        {
            Console.WriteLine("Öğrenci kayıt güncellendi.");
            return 1;
        }

        public int kayitSil(int id)
        {
            Console.WriteLine("Öğrenci kaydı silindi.");
            return 1;
        }
    }
}
