using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BolumSonuOdev
{
    internal class Musteri
    {
        #region Sanal Database
        static ArrayList musteriDatabase;
        #endregion

        #region Static yapıcı metot
        static Musteri()
        {
            musteriDatabase = new ArrayList();  
        }
        #endregion

        #region Field
        public int musteriID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }      
        public string sifre { get; set; }
        #endregion

        #region Kapsülleme
        private string _kullaniciAdi;
        public string kullaniciAdi
        {
            get { return this._kullaniciAdi; }
            set 
            {
                bool kullaniciAdiKontrol = musteriKullaniciAdiKontrol(value);
                if(kullaniciAdiKontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı adı sistemde kayıtlı");
                    this._kullaniciAdi = String.Empty;
                }
                else
                {
                    this._kullaniciAdi = value;
                }
            }
        }
        #endregion

        #region Static metotlar
        static bool musteriKullaniciAdiKontrol(string _kullaniciAdi)
        {
            bool Kontrol = false;

            for (int i = 0; i < musteriDatabase.Count; i++)
            {
                Musteri Temp = (Musteri)musteriDatabase[i];
                if (Temp.kullaniciAdi == _kullaniciAdi)
                {
                    Kontrol = true;
                    break;
                }
            }
            return Kontrol;
        }
        public static void MusteriEkle(Musteri M)
        {
            #region Parametre kontrol
            if (M != null && !string.IsNullOrEmpty(M.kullaniciAdi) && !string.IsNullOrEmpty(M.emailAdres))
            {
                bool emailAdresKontrol = musteriEmailAdresKontrol(M.emailAdres);
                if (emailAdresKontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı sistemde kayıtlı");
                }
                else
                {
                    musteriDatabase.Add(M);
                    Console.WriteLine("Yeni kayıt işlemi başarılı!");
                }
            }
            #endregion
        }

        static bool musteriEmailAdresKontrol(string _emailAdres)
        {
            bool Kontrol = false;

            for (int i = 0; i < musteriDatabase.Count; i++)
            {
                Musteri Temp = (Musteri)musteriDatabase[i];
                if(Temp.emailAdres == _emailAdres)
                {
                    Kontrol=true;
                    break;
                }
            }
            return Kontrol;
        }
        #endregion



    }
}
