using System;
using System.Collections.Generic;
using System.Text;

namespace Kalitim
{
    internal class temelTip
    {
        public int id { get; set; }
        public string referansKod { get; set; }
        public string tcKimlikNo { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int cinsiyet { get; set; }
        public DateTime kayitTarih { get; set; }
        public int kayitKullanici { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public int guncellemeKullanici { get; set; }
        public bool silindi { get; set; }

        public temelTip()
        {
            Console.WriteLine("temel tip nesnesinin yapıcı metotu oluştu");
        }

        public void TemelTipMetot1()
        {
            Console.WriteLine("temel tip => metot1 çalıştı");
            // TemelTipMetot2(); protected olduğu için class içerisinde private gibi davranır.
        }
        
        protected void TemelTipMetot2()
        {
            Console.WriteLine("temel tip => protected metot2 çalıştı");
        }
    }
}
