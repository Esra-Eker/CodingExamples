using System;
using System.Collections.Generic;
using System.Text;

namespace InnerType
{
    internal class Musteri
    {
        #region Tekil olarak kullanılan field
        public int musteriID { get; set; }
        public string tcKimikNumarasi { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime olusturmaTarihi { get; set; }
        public int kullaniciId { get; set; }
        #endregion

        #region Inner Type gerektiren field lar
        public MusteriAdres[] musteriAdresleri;
        public MusteriIletisimBilgisi[] musteriIletisimBilgileri;
        public MusteriSiparisBilgisi[] musteriSiparisBilgileri;
        
        #endregion

        public Musteri()
        {
            musteriAdresleri = new MusteriAdres[5];
            musteriIletisimBilgileri = new MusteriIletisimBilgisi[3];
            musteriSiparisBilgileri = new MusteriSiparisBilgisi[10];
        }
    }
}
