using System;
using System.Collections.Generic;
using System.Text;

namespace Kalitim
{
    internal sealed class Egitmen : Personel  // sealed diyince bu nesne örneklenemez! yani başka bi yerde inherit edemiyoz.
    {
        public string brans { get; set; }
        public int bransSeviye { get; set; }

        public Egitmen()
        {
            Console.WriteLine("eğitmen nesnesinin yapıcı metodu çalıştı");
        }
    }
}

