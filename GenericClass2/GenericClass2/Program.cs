using System;
using System.Collections.Generic;

namespace GenericClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericRepository<Musteri> repositoryMusteri = new GenericRepository<Musteri>();  //database e git, müşterileri getir.
            
            List<Musteri> musterilerim = repositoryMusteri.Getir();

            repositoryMusteri.yeniKayitEkle(null);

            GenericRepository<Urun> repositoryUrun = new GenericRepository<Urun>();
            repositoryUrun.Getir();

            repositoryUrun.yeniKayitEkle(null);
        }
    }
}
