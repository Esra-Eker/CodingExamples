using System;
using System.Linq;

namespace StrongPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string password = Console.ReadLine();

            int result = minimumNumber(n, password);
            Console.WriteLine(result);
        }
        public static int minimumNumber(int n, string password)
        {
            string numbers = "0123456789";
            string lower_case = "abcdefghijklmnopqrstuvwxyz";
            string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string special_characters = "!@#$%^&*()-+";
            int add = 0;

            if (!password.Intersect(numbers).Any())
            {
                add++;
            }

            if (!password.Intersect(lower_case).Any())
            {
                add++;
            }

            if (!password.Intersect(upper_case).Any())
            {
                add++;
            }

            if (!password.Intersect(special_characters).Any())
            {
                add++;
            }

            int characters = Math.Max(add, 6 - n);
            return characters;

        }
    }
}
