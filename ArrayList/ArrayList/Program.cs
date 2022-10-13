using System;
using System.Collections;
using System.Collections.Generic;


namespace ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[10];

            System.Collections.ArrayList A1 = new System.Collections.ArrayList();
            A1.Add("assad");
            A1.Add(2);

            //A1.AddRange(bişi); arrayliste başka bir arraylistten bişi atabiliriz.
            //A1.Remove();  araylistten eleman siler
            //A1.Reverse();  listeyi ters çevirir.
            //A1.Sort(); sıralar
            //A1.Contains(); listenin içerisinde var mı diye kontrol eder.
            //A1.IndexOf();  değerin listede kaçıncı indexte olduğunu gösterir.
            //A1.Clear(); arraylistin içeirisndeki her şeyi siler.


            List<Ogrenci> isimler2 = new List<Ogrenci>();
            isimler2.Add(new Ogrenci() { name = "esra", yas = 1 });
        }
    }

    public class Ogrenci
    {
        public string name { get; set; }
        public int yas { get; set; }
    }
}
