using System;
using System.Collections.Generic;

namespace DictionarySortedListKoleksiyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary<TKey,TValue>   
           
            Dictionary<int,string> DictionaryList = new Dictionary<int,string>();
            DictionaryList.Add(1, "bir");
            DictionaryList.Add(2, "iki");
            DictionaryList.Add(3, "üç");
            // DictionaryList.Add(1, "test");  Key değeri koleksiyon içerisinde tekil, benzersiz olmalı.
        
            bool silmeSonuc = DictionaryList.Remove(1);
            if (silmeSonuc)
            {
                Console.WriteLine("Silindi.");
            }
            else
            {
                Console.WriteLine("Aranan değer liste içerisinde bulunamadı, silme işlemi başarısız.");
            }   

            bool arananDegerSonuc = DictionaryList.ContainsKey(1);
            if (arananDegerSonuc)
            {
                string gelenDeger = DictionaryList[1];
                gelenDeger = "Yenilenen Değer";
                DictionaryList[1] = gelenDeger;
            }
            else
            {
                Console.WriteLine("Aranan değer koleksiyon içerisinde bulunamadı.");
            }

            bool arananDegerSonuc2 = DictionaryList.ContainsValue("Üç");
            if (arananDegerSonuc2)
            {
                Console.WriteLine("Aranan değer bulundu.");
            }
            else
            {
                Console.WriteLine("Aranan değer bulunamadı.");
            }

            foreach (KeyValuePair<int,string> item in DictionaryList)
            {
                Console.WriteLine("Anahtar : {0} || Değer : {1}", item.Key, item.Value);
            }

            DictionaryList.Clear();

            SortedList<int,string> sortedListKoleksiyon = new SortedList<int,string>();

            sortedListKoleksiyon.Add(100, "Yüz");
            sortedListKoleksiyon.Add(50, "Elli");
            sortedListKoleksiyon.Add(1, "Bir");
            sortedListKoleksiyon.Add(1000, "Bin");
        }
    }
}
