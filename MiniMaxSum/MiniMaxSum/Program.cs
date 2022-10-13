using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniMaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            //miniMaxSum1(arr);
            miniMaxSum2(arr);
        }

        public static void miniMaxSum1(List<int> arr)
        {
            int minSum = 0;
            int maxSum = 0;
            for (int i = 0; i < arr.Count - 1; i++)
            {
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Count - 1; i++)
                minSum += arr[i];
            for (int i = arr.Count - 1; 0 < i; i--)
                maxSum += arr[i];

            Console.Write(minSum + " " + maxSum);
        }

        public static void miniMaxSum2(List<int> arr)
        {
            int max = arr[0];
            int min = arr[0];
            int sum = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (max < arr[i])
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
                sum += arr[i];
            }
            Console.WriteLine((sum-max) + " " + (sum-min));
        }
    }
}
