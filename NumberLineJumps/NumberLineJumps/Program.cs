using System;

namespace NumberLineJumps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int x1 = Convert.ToInt32(firstMultipleInput[0]);

            int v1 = Convert.ToInt32(firstMultipleInput[1]);

            int x2 = Convert.ToInt32(firstMultipleInput[2]);

            int v2 = Convert.ToInt32(firstMultipleInput[3]);

            string answer = kangaroo(x1, v1, x2, v2);
            Console.WriteLine(answer);
        }
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            for (int i = 1; i < 20; i++)
            {
                if (x1 + (v1 * i) == x2 + (v2 * i))
                {
                    return "YES";
                }
            }
            return "NO";
        }
    }
}
