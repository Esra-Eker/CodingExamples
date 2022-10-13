using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectronicsShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bnm = Console.ReadLine().Split(' ');

            int b = Convert.ToInt32(bnm[0]);

            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
                ;

            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
                ;
            /*
             * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
             */

            int moneySpent = getMoneySpent(keyboards, drives, b);
            Console.WriteLine("----------------" + moneySpent);
        }
        static int getMoneySpent(int[] keyboards, int[] drives, int b) 
        {
            List<int> maxList = new List<int>();
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    if(keyboards[i]+drives[j]<b)
                        maxList.Add(keyboards[i]+drives[j]);
                }
            }

            if (maxList.Count == 0)
                return -1;
            return maxList.Max();
        }
    }
}
