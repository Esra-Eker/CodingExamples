using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CountingSort1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            countingSort(arr, n);
        }


        public static void countingSort(List<int> arr, int n)
        {
            int[] dizi = new int[n];

            for (int i = 0; i < arr.Count; i++)
            {
                dizi[arr[i]]++;
            }
            for (var i = 0; i < 100; i++)
            {
                Console.Write(dizi[i] + " ");
            }
        }
    }
}
