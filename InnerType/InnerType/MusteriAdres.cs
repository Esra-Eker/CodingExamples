using System;
using System.Collections.Generic;
using System.Text;

namespace InnerType
{
    internal class MusteriAdres
    {
        public string adresTip { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string adres { get; set; }

        public MusteriAdres()
        {
            Console.WriteLine("Müşteri adres yapıcı metodu çalıştı");
        }
    }
}
