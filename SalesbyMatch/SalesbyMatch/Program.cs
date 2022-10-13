using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesbyMatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = sockMerchant(n, ar);
            Console.WriteLine(result);
        }
        public static int sockMerchant(int n, List<int> ar)
        {
            int num = 0;
            for (int i = 0; i < ar.Count - 1; i++)
            {
                for (int j = i+1; j < ar.Count; j++)
                {
                    if (ar[i] == ar[j])
                    {
                        num++;
                        ar.RemoveAt(j);
                        ar.RemoveAt(i);
                        j--;
                        i--;
                        break;
                    }
                    
                }

                
            }
            return num;

        }
    }
}
