using System;
using System.Collections.Generic;
using System.Text;

namespace MetotGenelTanim
{
    public class Ogrenci
    {
        public void selamlaOgrenci()
        {
            Console.WriteLine("Merhaba Öğrenci!");
        }

        /* [ErişimBelirleyici] <GeriDonusDegeri> MetotAdi (Parametreler)
        *  {
        *       //Metot için gereken kodlar
        *  }
        *
        *   Erişim Belirleyicisi
        *   
        *   public
        *   private  metot, içinde bulunduğu class düzeyinde çağırılabilir.
        *   protected
        *   internal   ilgili kütüphane içerisinde metota ulaşabilirsin.
        *   internal protected  ilgili kütüphaneden veya bi yerden kalıtıldıysa ulaşabilirsin.
        *
        */

        public void OgrenciMetot1(string ogrenciAdi, string ogrenciSoyadi)
        {
            Console.WriteLine("Öğrenci Bilgileri: {0} {1}", ogrenciAdi, ogrenciSoyadi);
        }

        public void OgrenciMetot2()
        {
            OgrenciMetot1("Hey", "Sen");
        }
    }
}
