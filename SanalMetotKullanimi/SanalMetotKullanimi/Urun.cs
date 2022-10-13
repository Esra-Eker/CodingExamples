using System;
using System.Collections.Generic;
using System.Text;

namespace SanalMetotKullanimi
{
    internal class Urun : BaseClass
    {
        public Urun()
        {
            Console.WriteLine("ürün");
        }
        public override void ekranaYaz(string data)
        {
            Console.WriteLine("Urun => " + data);
        }
    }
}
