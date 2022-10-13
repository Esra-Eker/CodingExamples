using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BirthdayCakeCandles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            birthdayCakeCandles(candles);
        }
        public static void birthdayCakeCandles(List<int> candles)
        {
            int number=0;
            int max = 0;

            for(int i=0; i<candles.Count; i++)
            {
                if(max<candles[i])
                    max=candles[i];
            }
            for (int j = 0; j < candles.Count; j++)
            {
                    if(candles[j]==max)
                        number++;
            }

            Console.Write(number);
        }
    }
}
