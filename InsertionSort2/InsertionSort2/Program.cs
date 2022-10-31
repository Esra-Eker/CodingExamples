using System;
using System.Collections.Generic;
using System.Linq;

namespace InsertionSort2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            //insertionSort2(n, arr);
            insertionSort3(n, arr);
        }
        public static void insertionSort2(int n, List<int> arr)
        {
            for (int i = 1; i < arr.Count; i++)
            {
                for (int j = i; 0 < j; j--)
                {
                    if (arr[j] > arr[j - 1])
                    {
                        foreach (var item in arr)
                            Console.Write(item + " ");
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;

                        foreach (var item in arr)
                            Console.Write(item + " ");
                        Console.WriteLine();
                    }
                }
            }
        }

        //Doğru output
        public static void insertionSort3(int n, List<int> arr)
        {
            for (int i = 1; i < arr.Count; i++)
            {
                for (int j = i; 0 < j; j--)
                {
                    if (arr[j] > arr[j - 1])
                    {
                        break;
                    }
                    else
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
                foreach (var item in arr)
                    Console.Write(item + " ");
                Console.WriteLine();
            }
        }
    }
}
