using System;
using System.Collections.Generic;
using System.Linq;

namespace AppleAndOrange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int s = Convert.ToInt32(firstMultipleInput[0]);

            int t = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int a = Convert.ToInt32(secondMultipleInput[0]);

            int b = Convert.ToInt32(secondMultipleInput[1]);

            string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int m = Convert.ToInt32(thirdMultipleInput[0]);

            int n = Convert.ToInt32(thirdMultipleInput[1]);

            List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

            List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();
            //countApplesAndOranges2(s, t, a, b, apples, oranges);
            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
        public static void countApplesAndOranges2(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            List<int> newApples = new List<int>();
            List<int> newOranges = new List<int>();
            int numApple = 0;
            int numOrange = 0;

            foreach (var apple in apples)
            {
                newApples.Add(apple + a);
            }

            foreach (var orange in oranges)
            {
                newOranges.Add(orange + b);
            }

            for (int i = s; i < t + 1; i++)
            {
                foreach (var apple in newApples)
                {
                    if (i == apple)
                        numApple++;
                }

                foreach (var orange in newOranges)
                {
                    if (i == orange)
                        numOrange++;
                }
            }
            Console.WriteLine(numApple + " " + numOrange);
        }

        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int numApple = 0;
            int numOrange = 0;

            for (int i = 0; i < apples.Count; i++)
            {
                if (s <= apples[i] + a && apples[i] + a <= t)
                    numApple++;
            }

            for (int i = 0; i < oranges.Count; i++)
            {
                if (s <= oranges[i] + b && oranges[i] + b <= t)
                    numOrange++;
            }
            Console.WriteLine(numApple + " " + numOrange);
        }
    }
}
