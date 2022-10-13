using System;
using System.Collections.Generic;
using System.Text;

namespace Kalitim
{
    internal class Personel : temelTip
    {
        public DateTime isBaslangıcTarih { get; set; }
        public DateTime isBitisTarih { get; set; }
        public int izinGunSayisi { get; set; }

        public Personel()
        {
            Console.WriteLine("Personel nesnesi yapıcı metot çalıştı");
        }
    }
}
