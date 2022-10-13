using System;
using System.Collections.Generic;
using System.Text;

namespace KalitimOdev
{
    internal class BaseClass
    {
        public static int sayac = 1; // ilk oluştuğu zaman 1 değerini otomatik oalrak alsın.

        public BaseClass()
        {
            _id = sayac;
            sayac = sayac + 1;
        }
        private int _id;
        public int id
        {
            get // değeri içeriden dışarı gönderme işlemi
            {
                return _id;
            }
            private set
            {
                // bi sayaç içerisindeki değerden faydalanmak istiyoruz
                //_id = sayac;
                //sayac = sayac + 1;
                //id değeri artmıyor, çünkü, set alanı private olarak işaretlendi bu yüzden değer atılamıyor.
            }
        } // *

        private string _barkod;
        public string barkod 
        { 
            get
            {
                return _barkod;
            }
            set
            {
                bool kontrolIslemi = sanalDatabase.dbBarkodKontrol(value);
                if(!kontrolIslemi) // değeri sanal database içerisinde bulamadım.
                {
                    _barkod = value;
                }
                else
                {
                    Console.WriteLine("Sanal database içerisinde bu barkod değeri daha önce girilmiştir.");
                }
            }
        } // *

        public DateTime olusturmaTarih { get; set; }
        public int olusturanKullanici { get; set; }

        public DateTime guncellemeTarih { get; set; }
        public int guncelleyenKullanici { get; set; }

        public bool silindi { get; set; }

    }
}
