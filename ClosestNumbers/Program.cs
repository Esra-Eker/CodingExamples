using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ClosestNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = closestNumbers(arr);

            foreach (var item in result)
                Console.Write(item + " ");
        }
        public static List<int> closestNumbers(List<int> arr)
        {
            arr.Sort();
            int min = Math.Abs(arr[0] - arr[1]);
            List<int> newList = new List<int>();

            for (int i = 0; i < arr.Count - 1; i++)
            {
                var difference = Math.Abs(arr[i] - arr[i + 1]);
                if (difference < min)
                {
                    newList.Clear();
                    min = difference;
                    newList.Add(arr[i]);
                    newList.Add(arr[i + 1]);
                }
                else if (difference == min)
                {
                    newList.Add(arr[i]);
                    newList.Add(arr[i + 1]);
                }
            }
            return newList;
        }
    }
}
