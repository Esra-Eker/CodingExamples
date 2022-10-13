using System;
using System.Collections.Generic;

namespace AlternatingCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> output = new List<int>();
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = alternatingCharacters(s);
                output.Add(result);
            }

            foreach (var x in output)
            {
                Console.WriteLine(x);
            }
        }
        public static int alternatingCharacters(string s)
        {
            int delNum = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == 'A')
                {
                    if (s[i + 1] != 'B')
                    {
                        delNum++;
                    }

                }
                else
                {
                    if (s[i + 1] != 'A')
                    {
                        delNum++;
                    }
                }
            }

            return delNum;
        }
    }
}
