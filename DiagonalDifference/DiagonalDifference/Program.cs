using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Channels;

namespace DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaça kaçlık bir matris istersin? ");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            diagonalDifference(arr);

        }
        public static int diagonalDifference(List<List<int>> arr)
        {
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = i; j < arr.Count; j+=arr.Count)
                {
                    sum1+=arr[i][j];
                }

                for (int j = arr.Count-i-1; 0 <= j; j-=arr.Count)
                {
                    sum2+=arr[i][j];
                }
            }
            return Math.Abs(sum1-sum2);
        }
    }
}
