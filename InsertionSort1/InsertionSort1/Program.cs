using System;
using System.Collections.Generic;
using System.Linq;

namespace InsertionSort1
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
            int lastNum = arr[arr.Count - 1];

            for (int i = arr.Count - 2; 0 <= i; i--)
            {
                if (arr[i] > lastNum)
                {
                    arr[i + 1] = arr[i];
                    foreach (var item in arr)
                        Console.Write(item + " ");
                    Console.WriteLine();
                    if (i == 0)
                    {
                        arr[i] = lastNum;
                        foreach (var item in arr)
                            Console.Write(item + " ");
                        Console.WriteLine();
                    }
                }
                else
                {
                    arr[i + 1] = lastNum;
                    foreach (var item in arr)
                        Console.Write(item + " ");
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}
