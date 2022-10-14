using System;
using System.Collections.Generic;
using System.Linq;

namespace FunnyString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var results = new List<string>();

            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                results.Add(funnyString(s));
            }

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
        public static string funnyString(string s)
        {
            var list1 = new List<int>();
            var list2 = new List<int>();

            for (int i = 0; i < s.Length-1; i++)
            {
                list1.Add(Math.Abs(s[i] - s[i + 1]));
            }

            for (int i = s.Length-1; 0<i; i--)
            {
                list2.Add(Math.Abs(s[i] - s[i - 1]));
            }

            if (list1.SequenceEqual(list2))
                return "Funny";
            return "Not Funny";
        }
    }
}
