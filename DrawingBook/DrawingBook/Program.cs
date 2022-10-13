using System;

namespace DrawingBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int p = Convert.ToInt32(Console.ReadLine().Trim());

            int result = pageCount(n, p);
            Console.WriteLine(result);
        }
        public static int pageCount(int n, int p)
        {
            int num = 0;
            if (p <= n / 2)
            {
                for (int i = 1; i < n / 2; i++)
                {
                    if (i == p)
                        break;
                    if (i % 2 != 0)
                        num++;
                }
            }
            else
            {
                for (int i = n; n / 2 < n; i--)
                {
                    if (i == p)
                        break;
                    if (i % 2 == 0)
                        num++;
                }
            }
            return num;
        }
    }
}
