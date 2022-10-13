using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceNedir
{
    internal interface IMusteri  // interfacelarda metotların bodyleri bulunmaz sadece imzaları bulunur.
    {
        //public IMusteri()
        //{

        //}
        // interface içerisinde yapıcı metot kullanılmaz.

        // interface in içerisinde neler olur?

        // field

        int Id { get; set; }
        string isim { get; set; }
        string soyisim { get; set; }

        // metot

        int yeniKayit(string isim, string soyisim);
        int kayitDüzenle(int id, string isim, string soyisim);
        int kayitSil(int id);

        // delegate.. vb.

    }
}
