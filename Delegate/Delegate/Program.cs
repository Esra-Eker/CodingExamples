using System;

namespace Delegatex
{
    internal class Program
    {
        delegate void MatematikselIslemler(int sayi1, int sayi2);
        static void Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam işleminin sonucu: {0}", sonuc);
        }
        static void Çıkart(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("Çıkartma işleminin sonucu: {0}", sonuc);
        }
        static void Carp(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine("Çarpma işleminin sonucu: {0}", sonuc);
        }
        static void Main(string[] args)
        {
            //Topla(10, 20);
            //Çıkart(20, 15);
            //Carp(20, 2);

            MatematikselIslemler M1 = new MatematikselIslemler(Topla);
            M1 += Carp;
            M1 += Çıkart;

            // M1.Invoke(10, 20);

            Delegate[] IsaretEdilenMetotlar = M1.GetInvocationList();
            
            foreach (var item in IsaretEdilenMetotlar)
            {
                Console.WriteLine(item.Method.Name + "----");
            }

            M1 -= Carp;
            foreach (var item in M1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }

            M1 -= Çıkart;
            foreach (var item in M1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }

            M1 += Carp;
            foreach (var item in M1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }


            Console.ReadLine();
        }
    }
}
