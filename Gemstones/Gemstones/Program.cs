using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Gemstones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> arr = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string arrItem = Console.ReadLine();
                arr.Add(arrItem);
            }
            int result = gemstones(arr);
            Console.WriteLine(result);
        }
        public static int gemstones(List<string> arr)
        {
            //var result = arr.OrderBy(x => x.Length).ToList();

            int gemNum = 0;
            string s = arr[0];

            for (int i = 0; i < s.Length; i++)  //ilk elemana girdik. ve uzunluğu kadar dönücez.
            {
                int count = 1;
                for (int j = 1; j < arr.Count; j++)
                {
                    if (arr[j].Contains(s[i]))
                    {
                        count++;
                        int index = arr[j].IndexOf(s[i]);
                        arr[j] = arr[j].Substring(0, index) + arr[j].Substring(index + 1);
                    }
                }

                if (count>=arr.Count) //????
                {
                    gemNum++;
                }
            }
            return gemNum;
        }
    }
}
