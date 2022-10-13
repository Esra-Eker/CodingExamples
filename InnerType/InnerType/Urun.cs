using System;
using System.Collections.Generic;
using System.Text;

namespace InnerType
{
    internal class Urun
    {
        public int urunId { get; set; }
        public string tanim { get; set; }
        public decimal fiyat { get; set; }

        public Urun()
        {
            Console.WriteLine("ürün yapıcı metodu çalıştı.");
        }
        public void UrunTestMetot()
        {
            Console.WriteLine("UrunTestMetot");
        }
    }
}
