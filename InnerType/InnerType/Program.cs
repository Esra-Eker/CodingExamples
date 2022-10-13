using System;

namespace InnerType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();

            M1.musteriID = 1;
            M1.tcKimikNumarasi = "123456789";
            M1.isim = "esra";
            M1.soyisim = "eker";
            M1.olusturmaTarihi = DateTime.Now;

            // M1.musteriAdresleri = new MusteriAdres[5];
            // asla yapma!  bunun yerine yapıcı metot içerisine yaz.

            M1.musteriAdresleri[0] = new MusteriAdres()
            {
                il = "istanbul",
                ilce = "üsküdar",
                adres = "adres..",
                adresTip = "ev"
            };

            M1.musteriSiparisBilgileri[0] = new MusteriSiparisBilgisi()
            {
                siparisNumarasi = "SIP0001"
            };

            M1.musteriSiparisBilgileri[0].urunler[0] = new Urun()
            {
                urunId = 1,
                tanim = "bilgisayar",
                fiyat =10000
            };
        }
    } 
}
