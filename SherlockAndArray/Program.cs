using System;
using System.Collections.Generic;
using System.Linq;

namespace SherlockAndArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine().Trim());

            for (int TItr = 0; TItr < T; TItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                string result = balancedSums(arr);

                Console.WriteLine(result);
            }
        }
        public static string balancedSums(List<int> arr)
        {
            int sum = 0;
            int x = 0;
            foreach (var item in arr)
            {
                sum += item;
            }

            for (int i = 0; i < arr.Count; i++)
            {
                if (2 * x == sum - arr[i])
                {
                    return "Yes";
                }
                x += arr[i];
            }
            return "No";
        }
    }
}
