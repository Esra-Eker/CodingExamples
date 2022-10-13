using System;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TemelSınıf T1 = new TemelSınıf(); TemelSınıf madem bir şablon o zaman ben bunu örnekleyemem. yani abstract classlar örneklenemez.
            Musteri M1 = new Musteri();
            M1.Test();
            M1.testAbstract();
        }
    }
}
