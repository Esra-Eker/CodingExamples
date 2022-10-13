using System;

namespace PalindromeIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = palindromeIndex(s);
            }
        }
        public static int palindromeIndex(string s)
        {

        }
    }
}
