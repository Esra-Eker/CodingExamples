using System;

namespace MaxProductOfThree2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = { -10, -5, 2, 5, 4, 7, 3, -14, 4 };
         
            int min1 = int.MaxValue;
            int min2 = int.MaxValue;

            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;
          
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i]<=min1)
                {
                    min2 = min1;
                    min1 = n[i];
                }
                else if (n[i]<=min2)
                {
                    min2 = n[i];
                }
                if (max1 <= n[i])
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = n[i];
                }
                else if (max2 <= n[i])
                {
                    max3 = max2;
                    max2 = n[i];
                }
                else if(max3 <= n[i])
                {   
                    max3 = n[i];
                }
            }
            Console.WriteLine("En büyük 3 sayının çarpımı: {0}", Math.Max(min1*min2*max1,max1*max2*max3));
            Console.ReadLine();
        }
    }
}
