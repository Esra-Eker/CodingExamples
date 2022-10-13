using System;
using System.Security.Cryptography.X509Certificates;

namespace Staircase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            
            Staircase(n);
            
        }

        public static void Staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string a=String.Empty;
                for (int j = i; j<=n-1; j++)
                {
                    a += " ";
                }

                for (int j = n-i; j < n; j++)
                {
                    a += "#";
                }
                Console.WriteLine(a);
            }
        }
    }
}
