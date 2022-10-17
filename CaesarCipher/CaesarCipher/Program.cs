using System;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string s = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine().Trim());

            string result = caesarCipher(s, k);
            Console.WriteLine(result);
        }
        
        public static string caesarCipher(string s, int k)
        {
            char[] charAr = s.ToCharArray();

            for (int i = 0; i < charAr.Length; i++)
            {
                if ('a' <= charAr[i] && charAr[i] <= 'z')
                {
                    charAr[i] = (char)('a' + ((s[i] - 'a' + k) % 26));  //alfabe 26 harften oluştuğundan z'den sonra tekrar başa dönebilmesi için 26dan kalanını alıyoruz.!
                }

                if ('A' <= charAr[i] && charAr[i] <= 'Z')
                {
                    charAr[i] = (char)('A' + ((s[i] - 'A' + k) % 26));
                }
            }
            return new string(charAr);
        }
    }
}
