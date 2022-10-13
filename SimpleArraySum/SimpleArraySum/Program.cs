using System;

namespace SimpleArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gireceğiniz sayı sayısını giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[n];
            int sum = 0;

            //Console.WriteLine(n + " tane sayı girin: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(i+1 +  ". elemanı girin:");
                dizi[i]=Convert.ToInt32(Console.ReadLine());
                sum += dizi[i];
            }
            Console.WriteLine("Toplam: " + sum);
            Console.ReadKey();
        }
    }
}
