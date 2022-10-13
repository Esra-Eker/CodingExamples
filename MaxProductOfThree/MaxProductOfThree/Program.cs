using System;

namespace MaxProductOfThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carpim = 1;
            int temp;
            int[] numbers = {2, 5, 4, 8, 3, 1, 4 };
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    temp = numbers[i];
                    numbers[i] = numbers[i + 1];
                    numbers[i + 1] = temp;
                    i = -1;
                }
            }
            Console.WriteLine("");

            for (int i = 0; i < 3; i++)
            {
                carpim *= numbers[i];
            }
            Console.WriteLine("En büyük 3 sayının çarpımı: {0}", carpim);
            Console.ReadLine();



        }
    }
}
