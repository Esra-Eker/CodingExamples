using System;
using System.Collections.Generic;
using System.Text;

namespace InnerType
{
    internal class MusteriSiparisBilgisi
    {
        public string siparisNumarasi { get; set; }

        public Urun[] urunler;

        public MusteriSiparisBilgisi()
        {
            urunler = new Urun[2];
        }
    }
}
