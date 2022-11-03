using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MissingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int m = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            List<int> result = missingNumbers(arr, brr);

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }
        public static List<int> missingNumbers(List<int> arr, List<int> brr)
        {
            List<int> missingList = new List<int>();

            for (int i = 0; i < brr.Count; i++)
            {
                if (arr.Contains(brr[i]))
                {
                    arr.Remove((brr[i]));
                }
                else if (!missingList.Contains(brr[i]))
                {
                    missingList.Add(brr[i]);
                }
            }
            missingList.Sort();
            return missingList;
        }
    }
}
