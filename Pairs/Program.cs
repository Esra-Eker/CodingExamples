using System;
using System.Collections.Generic;
using System.Linq;

namespace Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = pairs(k, arr);

            Console.WriteLine(result);
        }

        //Time limit exceeded hatası verdi birkaç tanesinde.
        public static int pairs1(int k, List<int> arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Count - 1; i++)
            {
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) == k)
                    {
                        sum++;
                    }
                }
            }
            return sum;
        }

        public static int pairs(int k, List<int> arr)
        {
            int count = 0;
            foreach (var item in arr)
            {
                if (arr.Contains(item - k))
                    count++;
            }
            return count;
        }
    }
}
