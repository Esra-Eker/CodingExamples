using System;

namespace AritmetikselOperatorAlistirma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba!");

            Console.Write("İsminiz: ");
            string isim = Console.ReadLine();
            
            Console.Write("Soyisminiz: ");
            string soyisim = Console.ReadLine();

            Console.Write("Doğum yılınız: ");
            string yilStr = Console.ReadLine();
            
            Console.Clear();

            int yil = Convert.ToInt32(yilStr);
            //int mevcutYil = 2022;
            int mevcutYil = DateTime.Now.Year;
            int yas = mevcutYil - yil;

            Console.WriteLine("Merhaba " + isim + " " + soyisim + " " + yas + " yaşındasınız!");

            Console.ReadLine();
        }
    }
}
