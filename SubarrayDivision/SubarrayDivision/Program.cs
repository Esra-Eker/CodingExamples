using System;
using System.Collections.Generic;
using System.Linq;

namespace SubarrayDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            int result = birthday(s, d, m);
            Console.WriteLine(result);
        }
        public static int birthday(List<int> s, int d, int m)
        {
            int sum=0;
            int count=0;
        
            for(int i=0; i<s.Count; i++)
            {
                for(int j=i; j<i+m; j++)
                    if (j < s.Count)
                        sum+=s[j];
                if(sum==d)
                    count++;
                sum = 0;
            }
            return count;
        }
    }
}
