using System;
using System.Linq;

namespace PermMissingElem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 1, 4,6,0,-2,5,7,9 };
            int b = numbers.Min();
            
            for (int i = b+1; i < numbers.Length-1; i++)
            {
                if(numbers.Contains(i)==true)
                { 
                }
                else
                {
                    Console.WriteLine(i + " sayısı dizide yok!");
                }
            }       
            Console.ReadKey();
        }
    }
}
