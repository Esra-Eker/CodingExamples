using System;
using System.Collections.Generic;
using System.Linq;

namespace CompareTheTriplets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            compareTriplets(a,b);
        }
        public static void compareTriplets(List<int> a, List<int> b)
        {
            int alice=0;
            int bob=0;
        
            for(int i=0; i<3; i++)
            {
                if(a[i]>b[i])
                    alice++;
                else if (b[i]>a[i])
                    bob++;
                else
                    continue;
            }
            Console.WriteLine(alice + " " + bob);
        }
    }
}
