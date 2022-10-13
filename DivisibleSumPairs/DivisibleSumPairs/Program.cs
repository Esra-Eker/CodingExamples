using System;
using System.Collections.Generic;
using System.Linq;

namespace DivisibleSumPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dizinin eleman sayısını girin: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bölen sayıyı girin: ");
            int k = Convert.ToInt32(Console.ReadLine());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = divisibleSumPairs(n, k, ar);
            Console.WriteLine(result);
        }
        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int sayac = 0;
            for (int i = 0; i < ar.Count - 1; i++)
            {
                for (int j = i + 1; j < ar.Count; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        sayac++;
                    }
                }
            }
            return sayac;
        }
    }
}
