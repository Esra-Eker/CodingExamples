using System;
using System.Collections.Generic;
using System.Linq;

namespace ListGenericInceleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilarim = new List<int>();

            sayilarim.Add(1);

            int[] eklenecekData1 = new int[4];
            eklenecekData1[0] = 2;
            eklenecekData1[1] = 3;
            eklenecekData1[2] = 4;
            eklenecekData1[3] = 5;

            // 1. ama uzun bi yol.
            //for (int i = 0; i < eklenecekData1.Length; i++)
            //{
            //    sayilarim.Add(eklenecekData1[i]);
            //}

            // 2.yol 
            sayilarim.AddRange(eklenecekData1);

            // ----------------------------------------------------------

            int capacity = sayilarim.Capacity;
            int count = sayilarim.Count;

            sayilarim.TrimExcess(); //count ve capacity değerlerini birbirine eşitliyor.

            capacity = sayilarim.Capacity;
            count = sayilarim.Count;

            sayilarim.ForEach(i => Console.WriteLine(i));
            // => ilgili koleksiyon içerisinde arama yap anlamına geliyor.

            sayilarim.Insert(3, 100); // 3.indexe 100 değerini atar ve eski 3.index de bi alta kayar.
             
            bool kontrol1 = sayilarim.Any();  // koleksiyon içerisinde bi değer varsa true döndürcek.
            bool kontrol2 = sayilarim.Any(i => i > 5);  //koleksiyon içerisindeki her bi değere i de, i>5 ise true döndür değilse false döndür. içeride 100>5 değeri olduğu için true döndü.

            sayilarim.Sort();  // a - z
            sayilarim.Reverse();  // z - a

            int enYuksekDeger = sayilarim.Max();
            int enDusukDeger = sayilarim.Min();
            int toplamDeger = sayilarim.Sum();

            bool silmeIslemiSonuc = sayilarim.Remove(100);
            int silinenAdet = sayilarim.RemoveAll(i => i > 3);
            sayilarim.RemoveAt(2);

            sayilarim.Clear();
        }  
    }
}
 