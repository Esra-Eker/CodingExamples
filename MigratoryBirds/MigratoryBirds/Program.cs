using System;
using System.Collections.Generic;
using System.Linq;

namespace MigratoryBirds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp))
                .ToList();
            int result = migratoryBirds(arr);
            Console.WriteLine(result);
        }

        public static int migratoryBirds(List<int> arr)
        {
            int[] arrTemp = new int[6];

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    if (arr[i] == j)
                    {
                        arrTemp[j]++;
                    }
                }
            }

            int max = arrTemp.Max();
            for (int j = 0; j < arrTemp.Length; j++)
            {
                if (arrTemp[j] == max)
                    return j;
            }
            return -1;
        }
    }
}
