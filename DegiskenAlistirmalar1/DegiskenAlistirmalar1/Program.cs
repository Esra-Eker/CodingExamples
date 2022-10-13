using System;

namespace DegiskenAlistirmalar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");
            Console.Write("İsim: ");
            string isim = Console.ReadLine();

            Console.Write("Soyisim: ");
            string soyisim = Console.ReadLine(); 

            Console.Write("Şehir: ");
            string sehir = Console.ReadLine();

            Console.Write("Yaş: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("İsim: " + isim);
            Console.WriteLine("Soyisim: " + soyisim);
            Console.WriteLine("Şehir: " + sehir);
            Console.WriteLine("Yaş: " + yas);

            Console.ReadLine();
        }
    }
}
