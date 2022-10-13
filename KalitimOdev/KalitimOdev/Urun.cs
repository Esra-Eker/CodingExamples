using System;
using System.Collections.Generic;
using System.Text;

namespace KalitimOdev
{
    internal class Urun : BaseClass
    {
        public string marka { get; set; }  // * belirtmiş olduğumuz markalar içerisinde ürün eklenebilsin
        public string model { get; set; }

        private decimal _alisFiyat;
        public decimal alisFiyat
        {
            get
            {
                return _alisFiyat;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Alış fiyatı 0dan küçük veya eşit olamaz.");
                }
                else
                {
                    _alisFiyat = value;
                }
            }
        } // * 0dan küçük olmamalı

        private decimal _satisFiyat;
        public decimal satisFiyat
        {
            get
            {
                return _satisFiyat;
            }
            set
            {
                if (value < _alisFiyat)
                {
                    Console.WriteLine("Ürünün alış fiyatı satış fiyatından küçük olamaz.");
                }
                else
                {
                    _satisFiyat = value;
                }
            }
        } // * alisfiyatından küçük olamaz.

        private decimal _kampanyaFiyat;
        public decimal kampanyaFiyat
        {
            get
            {
                return _kampanyaFiyat;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Kampanya fiyatı 0dan küçük veya eşit olamaz.");
                }
                else
                {
                    _kampanyaFiyat = value;
                }
            }
        } // * kampanya fiyat değeri 0dan küçük olamaz
    }
}
