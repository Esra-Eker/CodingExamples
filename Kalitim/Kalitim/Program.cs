using System;

namespace Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //temelTip T1 = new temelTip();
            //T1.TemelTipMetot1();

            //Egitmen E1 = new Egitmen();
            //Console.WriteLine("eğitmen nesnesi örneklendi");
            //E1.TemelTipMetot1();

            //// Özel tiplerde boxing ve unboxing 


            //// Bizim object nesnemiz nedir?
            //// Temel tip.
            //temelTip T2;
            //// Hangi nesenelerde temeltip object görevi görür ?
            //// Personel, Eğitmen, Ogrenci
            //// Temeltip nesnesinden türedikleri için temel tip nesnesi bu nesnelerde object gibi davranır.

            //T2 = E1; // Eğitmen nesnesini temelTip nesnesine atadık.
            //E1 = (Egitmen)T2;

            //Personel P1 = new Personel();
            //P1.id = 13;
            //P1.isim = "esra";
            //P1.isBaslangıcTarih = DateTime.Now;

            //T2 = P1; // Personel nesnesini temelTip nesnesine atadık.
            //P1 = (Personel)T2;

            //Ogrenci O1 = new Ogrenci();
            //T2 = O1;
            //O1 = (Ogrenci)T2;

            //Personel P1 = new Personel();
            //P1.TemelTipMetot1();

            //Ogrenci O1 = new Ogrenci();
            //O1.TemelTipMetot1();

            //object Obj1 = O1;
            //O1 = (Ogrenci)Obj1;

            //Obj1 = P1;
            //P1 = (Personel)Obj1;

            //Egitmen E1 = new Egitmen();

            //Test T1 =new Test();
            //T1.

            // Hangi nesnemizin kalıtılmasını istemiyoruz? -Eğitmen.
            // Eğitmen nesnemizin kalıtılmasını istemiyorsak sealed olarak işaretlememiz gerek.
            // sealed anahtar kelimesi nesnenin içine verildiğinde bu nesnenin kalıtımı yapılamaz.

            // Boxing - unboxing
            //object O1 = E1;    boxing
            //E1 = (Egitmen)O1;  unboxing

            Egitmen E1 = new Egitmen();

            // Egitmen => Personel => TemelTip => Object
            // Object => TemelTip => Personel => Egitmen

        

        }
    }
}
