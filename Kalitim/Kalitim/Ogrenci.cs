using System;
using System.Collections.Generic;
using System.Text;

namespace Kalitim
{
    internal sealed class Ogrenci : temelTip
    {
        public string bolum { get; set; }
        public int seviye { get; set; }

        public Ogrenci()
        {
            Console.WriteLine("Ogrenci nesnesi yapıcı metot çalıştı");
            TemelTipMetot2(); // protected olarak işaretlendiği için ve bu nesne kendisini temelTip nesnesinden kalıttığı için protected seeviyesinde olan field veya metotlara erişebilir.
            // temelTip i Ogrencide kalıttığım için temelTip in içindeki protected metot2 yi çağırabiliyom. protected seviyesindeki her şey Ogrenci nesnesinde publiic olarak davranır.
        }
        
    }
}
