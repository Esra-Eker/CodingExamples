using System;
using System.Collections.Generic;
using System.Linq;

namespace InsertionSortAlgoritmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            insertionSort1(n, arr);
        }
        public static void insertionSort1(int n, List<int> arr)
        {
            for (int i = 0; i < arr.Count - 1; i++)
            {
                for (int j = i + 1; 0 < j; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
