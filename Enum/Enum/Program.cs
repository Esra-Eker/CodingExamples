using System;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.id = 1;
            M1.musteriNo = "msn001";
            M1.isim = "esra";
            M1.soyisim = "eker";
            M1.emailAdres = "esra.eker@gmail.com";

            sanalDatabase SB = new sanalDatabase();
            musteriReturnValue musteriKayitSonuc = SB.musteriYeniKayit(M1);

            if (musteriKayitSonuc == musteriReturnValue.kayitBasarili)
            {

            }
        }
    }
}
