using System;
using System.Collections;
using System.Collections.Generic;

namespace ListGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("bir");

            // <T> : T tipi demek .net framework içerisinde olan veya bizim oluşturduğumuz herhangi bir tip demek.

            List<int> listGeneric = new List<int>();
            listGeneric.Add(1);
            listGeneric.Add(2);
            // listGeneric.Add("uc"); int tipi verdik string değer veremeyiz.

            for (int i = 0; i < listGeneric.Count; i++)
            {
                Console.WriteLine(listGeneric[i]);
            }

            List<string> isimler = new List<string>();
            isimler.Add("esra");
            isimler.Add("dilara");
            //isimler.Add(123);

            for (int i = 0; i < isimler.Count; i++)
            {
                Console.WriteLine(isimler[i]);
            }
            
            List<Musteri> musteriListe = new List<Musteri>();
            musteriListe.Add(new Musteri()
            {
                id = 1,
                isim = "esra",
                soyisim="eker"
            });

            for (int i = 0; i < musteriListe.Count; i++)
            {
                Console.WriteLine(musteriListe[i].isim);
            }
            foreach (var item in musteriListe)
            {
                Console.WriteLine(item.isim);
            }
        }
    }
}