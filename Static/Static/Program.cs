using System;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stack bölge içerisinde pointer ımız oluştu.
            Ogrenci O1;
            // Stack bölgede pointer oluştuğu zaman static olan bir yapıcı metot çalıştı ve yine class içerisinde tanımlı olan static field, static metot static dediğimiz bölgede oluşturuldu.

            Ogrenci.Test2(); // nesne örneği ALINMADAN test2 yi kullanabildim.

            O1 = new Ogrenci();
            // Stack bölgede pointer, kendisini heap bölgede tamamladı. static olmayan tanımlarını tamamladı.
            O1.Test1(); // nesne örneği alındıktan sonra test1 adındaki metotuma ulaşabildim.
 
            /* static kavramı gerçek hayatta nerelerde kullanılır?
            nesne örneğinin alınmasını istemediğimiz, farklı parça metotları bir arada tutmak istediğimiz yardımcı classlarımızda kullanıyoruz.
            
            1-  Helper.cs => Kontroller (tckimno doğru mu vs..)  //static kavramını gerçekte dağınık yapıdkai kontrolleri bi class ın altında toplamak için kullanıyoruz.
            2-  Oluşturmuş olduğumuz nesnemizin => bağımlılığı farklı classlara olduğu için (yani proje içerisinde özel olduğu için) nesne içerisinde static metot tanımları yapılır.
            3-  Class içerisinde bir field (static) tanımı yapar, ilgili field içerisine bi değer ataması yaparız. Daha sonra uygulama içerisinde N farklı yerde oluşturmuş olduğumuz static field ımıza ulaşır ve değerimizi okuruz.
            4-  [ Uygulama ] => [ozelHelper] => [ DLL ] 
            
             */  
        }
    }
}
