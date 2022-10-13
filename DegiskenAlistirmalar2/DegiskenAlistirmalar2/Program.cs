using System;

namespace DegiskenAlistirmalar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //soru 1: string olarak verilen değeri bool tipine dönüştür.
            string metin1 = "True";
            bool bo1=bool.Parse(metin1);
            bool bo2 = Convert.ToBoolean(metin1);

            //soru 2: int içerisinde olan 100 değerini byte ve float değişken tiplerine dönüştür.
            int s1 = 100;
            byte by =(byte)s1;
            float f = s1;

            //soru 3: byte değişken içerisinde olan tipi decimal değişken tipine dönüştür.
            byte b1 = 10;
            decimal d1 = b1;
        }
    }
}
