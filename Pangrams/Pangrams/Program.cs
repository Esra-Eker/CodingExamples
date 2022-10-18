using System;

namespace Pangrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = pangrams(s);
            Console.WriteLine(result);
        }
        public static string pangrams(string s)
        {
            for(int i = 97; i <= 122; i++)
            {
                if(!s.ToLower().Contains((char)i))
                {
                    return "not pangram";
                }
            }
            return  "pangram";
        }
    }
}
