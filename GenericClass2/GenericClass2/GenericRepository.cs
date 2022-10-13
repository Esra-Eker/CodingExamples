using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClass2
{
    internal class GenericRepository<T> // where T : class    T bir class olsun diyoruz.
    {
        public GenericRepository()
        {
            // context : EF DBFirst
        }

        public virtual List<T> Getir()
        {
            // Amaç: Gelen T tipini database üzerinden sorgulamak ve elde etmiş olduğum kayıtları generic koleksiyon olarak bir üst katmana dönmek.
            return null;
        }

        public virtual void yeniKayitEkle(T data)
        {
            // Bize gelen T tipi içerisindeki bilgiyi T tipinin işaret etmiş olduğu tabloya ekliyoruz. 
        }
    }
}
