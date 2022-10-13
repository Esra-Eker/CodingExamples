using System;

namespace GenericClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusteriGeneric<int> musteriGeneric1 = new MusteriGeneric<int>();
            musteriGeneric1.id = 1;
            musteriGeneric1.isim="esra";
            musteriGeneric1.musteriNumarasiAl();

            MusteriGeneric<Guid> musteriGeneric2 = new MusteriGeneric<Guid>();
            musteriGeneric2.musteriNumarasiAl();

            
        }
    }
}
