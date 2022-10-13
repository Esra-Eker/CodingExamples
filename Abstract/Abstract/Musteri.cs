using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    internal class Musteri : TemelSınıf
    {
        public int musteriID { get; set; }
        public Musteri()
        {
            musteriID = 1;
        }

        public override void testAbstract()
        {
            Console.WriteLine("Musteri => testAbstract metotu");
        }
    }
}
