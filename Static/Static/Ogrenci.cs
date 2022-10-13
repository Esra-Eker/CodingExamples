using System;
using System.Collections.Generic;
using System.Text;

namespace Static
{
    internal class Ogrenci
    {
        public string Isım { get; set; }
        public string Soyisim { get; set; }
        public string EmailAdres { get; set; }
        
        public void Test1()
        {
            Console.WriteLine("Nesne örneği alındıktan sonra çalılan metot");
            Test2();
            // ** Static olmayan bir metot static olan bir metotu çağırabilir.
        }
        public static void Test2()
        {
            Console.WriteLine("Nesne örneği ALINMADAN kullanılabilen metot");
            // ** Static olan bir metot static olmayan bir metotu vb. çağıramaz. static olmayan bir nesneyi çağırabilmesi için önce o nesnenin nesne örneğine ulaşması gerekiyor.
        }
    }
}
