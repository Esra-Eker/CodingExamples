using System;

namespace SanalMetotKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Televizyon T1 = new Televizyon();
            T1.ekranaYaz("Hangisi ?");

            Urun U1 = new Urun();
            U1.ekranaYaz("Merhaba");

            BaseClass B1 = new BaseClass();
            B1.ekranaYaz("Merhaba");
        }
    }
}
