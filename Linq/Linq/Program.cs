using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static bool funcDelegateKullanimi1(Musteri m)
        {
            if (m.isim[0] == 'A')
                return true;
            else
                return false;
        }

        static bool predicateDelegateMetot(Musteri m)
        {
            if (m.dogumTarih.Year > 1990)
                return true;
            else
                return false;
        }

        static void musteriListele(Musteri m)
        {
            Console.WriteLine(m.isim + " " + m.soyisim);
        }

        static void Main(string[] args)
        {
            dataSource ds = new dataSource();
            List<Musteri> musteriListe = ds.musteriListesi();

            #region Linq İnceleme ve Ara Ödevler

            // Müşteri listesi içerisinde bulunan kayıtlardan ismi a ile başlayan soyisim değerinin içinde e olan ve doğum yılı 1985den büyük olan kayıtları getirin.

            var odevAlistirma = musteriListe.Where(I => I.isim.ToLower().StartsWith("a") && I.soyisim.ToLower().Contains("e") && I.dogumTarih.Year > 1985).Select(I => I);  // select(I=>I) müşteri nesnesini bana geri getir demek.

            Console.WriteLine(odevAlistirma.Count());

            var odevAlistirma2 = from I in musteriListe
                                 where
                                 I.isim.ToLower().StartsWith("a") &&
                                 I.soyisim.ToLower().Contains("e") &&
                                 I.dogumTarih.Year > 1985
                                 select I;
            Console.WriteLine(odevAlistirma2.Count());
            #endregion

            #region Action Delegate

            Action<Musteri> actionMusteri = new Action<Musteri>(musteriListele);
            musteriListe.ForEach(actionMusteri);

            musteriListe.ForEach(new Action<Musteri>(musteriListele));
            musteriListe.ForEach(delegate (Musteri m) { Console.WriteLine(m.isim + " " + m.soyisim); });
            musteriListe.ForEach((Musteri m) => { Console.WriteLine(m.isim + " " + m.soyisim); });
            musteriListe.ForEach((m) => { Console.WriteLine(m.isim + " " + m.soyisim); });

            #endregion

            #region Linq sorgularında Delegate kullanımı - Predicate Delegate (geriye her zaman boolean döner)

            Predicate<Musteri> predicate = new Predicate<Musteri>(predicateDelegateMetot);

            var delegateKullanimiPredicate1 = musteriListe.FindAll(predicate);

            var delegateKullanimiPredicate2 = musteriListe.FindAll(new Predicate<Musteri>(predicateDelegateMetot));

            var delegateKullanimiPredicate3 = musteriListe.FindAll(delegate (Musteri m) { return m.dogumTarih.Year > 1990; });

            var delegateKullanimiPredicate4 = musteriListe.FindAll((Musteri m) => { return m.dogumTarih.Year > 1990; });

            var delegateKullanimiPredicate5 = musteriListe.FindAll((m) => { return m.dogumTarih.Year > 1990; });

            var delegateKullanimiPredicate6 = musteriListe.FindAll(m => m.dogumTarih.Year > 1990);
            #endregion

            #region Linq sorgularında delegate kullanımı - Func Delegate  (geriye farklı tipler döner)

            var delegateKullanimi = musteriListe.Where(I => I.isim.StartsWith("A"));

            Func<Musteri, bool> funcDelegate1 = new Func<Musteri, bool>(funcDelegateKullanimi1);

            var delegateKullanimi2 = musteriListe.Where(funcDelegate1);

            delegateKullanimi2 = musteriListe.Where(funcDelegateKullanimi1);



            var delegateKullanimi3 = musteriListe.Where(new Func<Musteri, bool>(funcDelegateKullanimi1));
            var delegateKullanimi4 = musteriListe.Where(delegate (Musteri m) { return m.isim[0] == 'A' ? true : false; });
            var delegateKullanimi5 = musteriListe.Where((Musteri m) => { return m.isim[0] == 'A' ? true : false; });
            var delegateKullanimi6 = musteriListe.Where((m) => { return m.isim[0] == 'A' ? true : false; });
            var delegateKullanimi7 = musteriListe.Where(m => m.isim[0] == 'A');

            #endregion

            #region Alıştırmalar

            // 1: Müsteriler içerisinde ülke değeri A ile başlayan müşterileri Linq to metot kullanarak bulalım.

            IEnumerable<Musteri> musteriListeAlistirma1 = musteriListe.Where(I => I.ulke.StartsWith("A"));
            Console.WriteLine(musteriListeAlistirma1.Count());

            // 2: Müşterler listesi içerisindeki kayıtlardan isminin içinde b harfi geçen ve ülke değeri içerisinde a harfi geçen müşterilerin listesini getirin.

            var musteriListeAlistirma2 = musteriListe.Where((I) => I.isim.ToLower().Contains("b") && I.ulke.ToLower().Contains("a")).ToList();

            // 3: Müşteriler listesi içerisindeki kayıtlardan doğum yılı 1990 dan büyük olan ve isminin içerisinde a harfi geçen müşterileri 2 .yol olan linq to query ile bulalım.  

            var musteriListeAlistirma3 = from I in musteriListe
                                         where I.dogumTarih.Year > 1990 && I.isim.Contains("a")
                                         select I;
            Console.WriteLine(musteriListeAlistirma3.Count());

            // 4: Müşteriler listesi içerisindeki kayıtlardan doğum yılı 1990 dan büyük olan veya isminin içerisinde a harfi geçen müşterileri 2 .yol olan linq to query ile bulalım.

            var musteriListeAlistirma4 = from I in musteriListe
                                         where I.dogumTarih.Year > 1990 || I.isim.Contains("a")
                                         select I;
            Console.WriteLine(musteriListeAlistirma4.Count());

            #endregion

            #region Linq Sorgulama Çeşitleri

            // 1.yol

            int toplamMusteriAdet = musteriListe.Where(I => I.isim.StartsWith("A")).Count();


            // 2.yol

            var toplamMusteriBulunan = (from I in musteriListe
                                        where I.isim.StartsWith("A")
                                        select I);
            int toplamMusteriAdet2 = toplamMusteriBulunan.Count();

            #endregion

            #region Başlarken

            // A ile başlayan müşterilerin adedi

            int bulunanToplam = 0;
            for (int i = 0; i < musteriListe.Count; i++)
            {
                if (musteriListe[i].isim[0] == 'A')
                {
                    bulunanToplam++;
                }
            }

            Console.WriteLine("Liste içerisinde isim değeri A ile kayıt sayısı {0}", bulunanToplam);

            Console.WriteLine(musteriListe.Count);

            bulunanToplam = 0;


            bulunanToplam = musteriListe.Where(i => i.isim.StartsWith('A')).Count();

            Console.WriteLine("Liste içerisinde isim değeri A ile kayıt sayısı {0}", bulunanToplam);

            Console.ReadLine();

            #endregion
        }
    }
}
