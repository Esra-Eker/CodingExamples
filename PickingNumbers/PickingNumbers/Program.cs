using System;
using System.Collections.Generic;
using System.Linq;

namespace PickingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = pickingNumbers(a);
            Console.WriteLine(result);
        }
        public static int pickingNumbers(List<int> a)
        {
            List<int> newAr = new List<int>();
            a.Sort();
            int count = 0;

            for (int i = 0; i < a.Count; i++)
            {
                for (int j = i; j < a.Count; j++)
                {
                    if (Math.Abs(a[i] - a[j]) <= 1)
                        newAr.Add(a[j]);
                }

                if (newAr.Count > count)
                    count = newAr.Count;
                
                newAr.Clear();
            }
            return count;

        }
    }
}
