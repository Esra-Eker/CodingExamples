using System;
using System.Collections.Generic;
using System.Linq;

namespace BigSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> unsorted = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string unsortedItem = Console.ReadLine();
                unsorted.Add(unsortedItem);
            }

            List<string> result = bigSorting(unsorted);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public static List<string> bigSorting(List<string> unsorted)
        {
            var result = unsorted.OrderBy(a=>a.Length).ThenBy(a=>a).ToList();
            return result;
        }
    }
}
