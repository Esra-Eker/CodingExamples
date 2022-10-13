using System;

namespace CatsAndaMouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            string[] outputs = new string[q];

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = catAndMouse(x, y, z);
                outputs[qItr]=result;

            }

            foreach (var result in outputs)
            {
                Console.WriteLine(result);
            }
        }
        static string catAndMouse(int x, int y, int z)
        {

            if (Math.Abs(z - x) > Math.Abs(z - y))
                return "Cat B";
            else if (Math.Abs(z - x) == Math.Abs(z - y))
                return "Mouse C";
            else
                return "Cat A";
        }
    }

}
