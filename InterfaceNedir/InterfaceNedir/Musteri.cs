using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceNedir
{
    internal class Musteri : IMusteri
    {
        int _id;
        string _isim;
        string _soyisim;

        public int Id { get { return _id; } set { _id = value; } }
        public string isim { get { return _isim; } set { _isim = value; } } 
        public string soyisim { get { return _soyisim; } set { _soyisim = value; } }

        public int kayitDüzenle(int id, string isim, string soyisim)
        {
            Console.WriteLine("Kayıt düzenlendi.");
            return 1;
        }

        public int kayitSil(int id)
        {
            Console.WriteLine("Kayıt silindi.");
            return 1;
        }

        public int yeniKayit(string isim, string soyisim)
        {
            Console.WriteLine("Kayıt eklendi.");
            return 1;
        }
    }
}
