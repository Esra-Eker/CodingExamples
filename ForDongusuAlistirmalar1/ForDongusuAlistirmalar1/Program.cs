using System;

namespace ForDongusuAlistirmalar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcın girdiği sayının faktöriyel hesabını yapıp yazdır.
            Console.Write("Faktöriyelini almak istediğiniz sayıyı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int carpim = 1;
            for (int i = sayi; i > 0; i--)
            {
                carpim *=i;
            }

            Console.WriteLine("Girilen sayının faktöriyeli: " + carpim);
        }
    }
}
