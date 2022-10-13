using System;
using System.Collections.Generic;
using System.Text;

namespace PersonelUygulamasi
{
    internal static class Helper
    {
        // Static olarak işaretlenmiş classlar örneklenemez.
        // Helper H1 = new Helper();

        /*
        public Helper()  
        {
            Her nesne örneği alındığında uygulama standart yapıcı metoty çalıştırır.
        }
        */

        static Helper()
        {
            // Static yapıcı metotlar uygulama içerisinde istenildiği kadar çağırılsınlar sadece ilk çağrılmada çalışırlar.
            Console.WriteLine("Helper => Static class => static CTOR");
        }

        public static void emailGonder(string aliciEmailAdres,string konu, string icerik)
        {
            Console.WriteLine("Mail gönderim işlemi başarılı!");
        }

        /* 
         * 
        public void Test()  // Static olan classların içine standart ( static olmayan) metotlar yazamayız.
        {

        }

        public string Tanim { get; set; }   // static olan classların içine standart (static olmayan) field tanımları yazamayız.
        
        */


    }
}
