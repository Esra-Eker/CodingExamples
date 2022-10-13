using System;

namespace StringDonusumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metin1 = "100";

            int s1=int.Parse(metin1);
            int s2=Convert.ToInt32(metin1);

            string metin2 = "True";
            //int s3=int.Parse(metin2);   stringin int’e çevrilmesinde herhangi bir sıkıntı yoktur. ancak string metinsel ise tipi herhangi bir sayısal ifadeye dönüştürülemez hata ile karşılaşılır.
        
            bool b1=bool.Parse(metin2);
            bool b2=Convert.ToBoolean(metin2);

            string metin3 = null;

            //decimal d1=decimal.Parse(metin3);  değer null olunca Parse'ta hata alırız. Convert'te böyle bi sıkıntı yok.
            decimal d2=Convert.ToDecimal(metin3);

            bool b3= Convert.ToBoolean(metin3);  //boolean değerinin default değeri false'dur.
        }
    }
}
