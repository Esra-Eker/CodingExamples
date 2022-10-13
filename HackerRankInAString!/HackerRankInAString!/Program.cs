using System;
using System.Globalization;

namespace HackerRankInAString_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                string result = hackerrankInString(s);
                Console.WriteLine(result);
            }
        }
        public static string hackerrankInString1(string s)
        {
            char[] word = { 'h', 'a', 'c', 'k', 'e', 'r', 'r', 'a', 'n', 'k' };
            int sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (word[i] == s[j])
                    {
                        sum++;
                        break;
                    }
                }
            }

            if (sum == word.Length)
                return "YES";
            return "NO";
        }

        public static string hackerrankInString(string s)
        {
            char[] word = { 'h', 'a', 'c', 'k', 'e', 'r', 'r', 'a', 'n', 'k' };
            int sum = 0;
            int j = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]==word[j])
                {
                    sum++;
                    j++;
                }
                if (sum == 10)
                    return "YES";
            }
            return "NO";
        }
    }
}
