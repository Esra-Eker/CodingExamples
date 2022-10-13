using System;

namespace MetotGenelTanim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.selamlaOgrenci();
            ogrenci.OgrenciMetot1("Esra", "Eker");
            ogrenci.OgrenciMetot2();

        }
    }
}
