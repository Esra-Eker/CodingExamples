using System;
using System.Collections.Generic;
using System.Text;

namespace PersonelUygulamasi
{
    public class Personel
    {
        public static string domainAdres = "firmam.com";  // static field
        public string Isim { get; set; }
        public string Soyisim { get; set; }

        private string _emailAdres;
        public string EmailAdres
        {
            get
            {
                return _emailAdres;
            }
            set
            {
                this._emailAdres = value.ToLower() + "@" + Personel.domainAdres;
            }
        }
        public int Cinsiyet { get; set; }

        public Personel()
        {
            Console.WriteLine("Her uygulamada çalışan metot");
        }

        static Personel()
        {
            domainAdres = "firmam.com";
            Console.WriteLine("sadece 1 kez çalışacak");
        }
    }
}
