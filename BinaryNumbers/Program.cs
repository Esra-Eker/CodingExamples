using System;
using System.Linq;

namespace BinaryNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            // Short way:
            var b = Convert.ToString(n, 2).Split('0').OrderByDescending(x => x.Length);
            Console.WriteLine(b.First().Length);

            //Long way:
            string reverseBinary = ConvertToBinary(n);
            string binary = String.Join("", reverseBinary.Reverse());

            int max1Count = 0;
            int cur1Count = 0;
            foreach (char c in binary)
            {
                if (c == '1')
                {
                    cur1Count++;

                    if (cur1Count > max1Count)
                        max1Count = cur1Count;
                }
                else
                    cur1Count = 0;
            }

            Console.WriteLine(max1Count);
        }
        static string ConvertToBinary(int num)
        {
            string bin = (num % 2).ToString();
            int nextNum = num / 2;

            if (nextNum >= 1)
                return bin + ConvertToBinary(num / 2);
            return bin;
        }
    }
}
