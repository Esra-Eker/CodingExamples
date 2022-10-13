using System;

namespace DelegateIsimsizMetotKullanimi
{
    internal class Program
    {
        delegate void EkranaYaz(string Isim, string Soyisim);
        static void Main(string[] args)
        {
            // Varolan bir metodu kullanarak delegate içine ekleme:
            EkranaYaz Test1 = new EkranaYaz(Test1Metot);

            // İsimsiz metot kullanımı:
            EkranaYaz Test2 = new EkranaYaz(delegate(string Isim,string Soyisim) 
            {
                Console.WriteLine(Isim + " " + Soyisim);
            });

            // Lambda Exp kullanımı:
            EkranaYaz Test3 = (Isim, Soyisim) =>
            {
                Console.WriteLine(Isim + " " + Soyisim);
            };

            Test1("Esra", "Mesra");
            Test2("Dilara", "Milara");
            Test3("Berat", "Merat");
        }

        static void Test1Metot(string Isim,string Soyisim)
        {
            Console.WriteLine(Isim + " " + Soyisim);
        }
    }
}
