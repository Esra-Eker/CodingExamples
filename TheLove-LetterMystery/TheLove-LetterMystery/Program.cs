using System;

namespace TheLove_LetterMystery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = theLoveLetterMystery(s);
                Console.WriteLine(result);

            }
        }
        //çalışmıyo
        //public static int theLoveLetterMystery(string s)
        //{
        //    int num = 0;

        //    for (int i = 0; i < s.Length / 2; i++)
        //    {
        //        for (int j = s.Length - 1; (s.Length / 2)+1 <= j; j--)
        //        {
        //            if (s[i] != s[j])
        //            {
        //                num++;
        //                j++;
        //            }
        //        }
        //    }
        //    return num;
        //}


        //çalışmıyo
        //public static int theLoveLetterMystery(string s)
        //{
        //    int num = 0;
        //    string[] letters = { "a", "b", "c", "d" };
        //    string[] str = s.Split("");

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        for (int j = 0; j < letters.Length; j++)
        //        {
        //            if (str[i] != str[str.Length - 1 - i])
        //            {
        //                num++;
        //                str[str.Length - 1 - i] = letters[j];
        //            }
        //        }
        //    }
        //    return num;
        //}

        public static int theLoveLetterMystery(string s)
        {
            int pal = 0;
            for (int i = 0, j = s.Length - 1; i < s.Length / 2; i++, j--)
            {
                if (s[i] != s[j])
                    pal += Math.Abs(s[j] - s[i]);
            }
            return pal;
        }
    }
}
