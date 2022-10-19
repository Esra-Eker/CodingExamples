using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingSort2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp))
                .ToList();

            countingSort(arr, n);
        }

        public static void countingSort(List<int> arr, int n)
        {
            int[] dizi = new int[arr.Max() + 1];

            for (int i = 0; i < arr.Count; i++)
            {
                dizi[arr[i]]++;
            }

            for (int i = 0, j = 0; i < dizi.Length; i++)
            {
                while (dizi[i] > 0)
                {
                    arr[j] = i;
                    j++;
                    dizi[i]--;
                }
            }

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
