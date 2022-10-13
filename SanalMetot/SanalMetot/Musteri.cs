using System;
using System.Collections.Generic;
using System.Text;

namespace SanalMetot
{
    internal class Musteri // : Object => yazmıyoz çünkü Framework standart olarak tüm nesneleri objectten türetiyor.
    {
        public int musteriID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }

        public override string ToString() //override anahtar kelimesini kullandığımızda kullandığımız class, türemiş olduğu classın tüm sanal metotlarını karşımıza getirir.
        {
            return isim + " " + soyisim;
        }
    }
}
