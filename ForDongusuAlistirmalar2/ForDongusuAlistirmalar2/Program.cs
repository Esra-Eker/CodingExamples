using System;

namespace ForDongusuAlistirmalar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("");
            int carp;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    carp = i * j;
                    Console.Write(i + " * " + j + " = " + carp + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
