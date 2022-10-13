using System;
using System.Collections.Generic;

namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedList
            //SortedList<string, int> sortedList = new SortedList<string, int>();
            //SortedSet
            //SortedSet<string> sortedSet = new SortedSet<string>();
           

            HashSet<string> hashSet = new HashSet<string>();
            hashSet.Add("Ali"); // eklenecektir
            EkranaYaz(hashSet);
            hashSet.Add("Samet"); // eklenecektir 
            EkranaYaz(hashSet);
            hashSet.Add("Ali"); // eklenmeyecektir
            EkranaYaz(hashSet);
            hashSet.Add("Mustafa"); // eklenecektir
            EkranaYaz(hashSet);
            hashSet.Add("Yasin"); // eklenecektir
            EkranaYaz(hashSet);
            // eklenme_durumu false değerini alacaktır
            bool eklenme_durumu = hashSet.Add("Ali");
            Console.WriteLine(eklenme_durumu);
            Console.ReadKey();       

        }

        static void EkranaYaz(HashSet<string> kisiler)
        {
            Console.Clear(); // Her seferinde ekranı temizle
            foreach (var kisi in kisiler)
                Console.WriteLine(kisi);
            Console.ReadKey();
        }

    }
}
