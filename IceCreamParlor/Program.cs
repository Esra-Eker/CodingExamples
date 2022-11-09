using System;
using System.Collections.Generic;
using System.Linq;

namespace IceCreamParlor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int m = Convert.ToInt32(Console.ReadLine().Trim());

                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                List<int> result = icecreamParlor(m, arr);

                foreach (var item in result)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine("");
            }
        }
        public static List<int> icecreamParlor(int m, List<int> arr)
        {
            List<int> sumList = new List<int>();
            for (int i = 0; i < arr.Count-1; i++)
            {
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (arr[i] + arr[j] == m)
                    {
                        sumList.Add(i+1);
                        sumList.Add(j+1);
                    }
                }
            }
            return sumList;
        }
    }
}
