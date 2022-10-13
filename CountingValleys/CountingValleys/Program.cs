using System;

namespace CountingValleys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = countingValleys(steps, path);
            Console.WriteLine(result);
        }
        public static int countingValleys(int steps, string path)
        {
            char[] arr;
            arr = path.ToCharArray();
            int seaLevel = 0;
            int valleyNum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 'D')
                {
                    if(seaLevel == 0)
                        valleyNum++;
                    seaLevel--;
                }
                else
                    seaLevel++;
            }
            
            return valleyNum;


        }
    }
}
