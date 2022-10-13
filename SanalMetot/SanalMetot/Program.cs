using System;

namespace SanalMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.isim = "esra";
            M1.soyisim = "eker";
            string toStringMesaj = M1.ToString();
            Console.WriteLine(toStringMesaj);
        }
    }
}
