using System;
using System.Collections.Generic;
using System.Text;

namespace SanalMetotKullanimi
{
    internal class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("baseclass");
        }
        public virtual void ekranaYaz(string data) // sanal metot yapacağımız zaman metotumuza ek olarak virtual anahtar kelimesini kullanırız. virtual anahtar kelimesini kullandığımız zaman bu metotumuz sanal bir metot olur. kalıtımda sanal metotun temel görevi: eğer sanal metotu hiç ellemezsek BaseClass içerisinde yazılmış olduğu gibi çalışır.
        {
            Console.WriteLine(data);
        }
    }
}
