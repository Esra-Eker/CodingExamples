using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClass
{
    internal class MusteriGeneric<T>
    {
        public T id { get; set; }
        public T musteriNo { get; set; }
        public string tcKimlikNo { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime dogumTarih { get; set; }

        public T musteriNumarasiAl()
        {
            return musteriNo;
        }
    }
}
