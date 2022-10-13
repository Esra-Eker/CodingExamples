using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    internal abstract class TemelSınıf // abstract diyince demiş oldum ki: bu TemelSınıf aslında benim şablon olarak kullanacağım bir sınıf. ben bu sınıfı bir kural kütüphanesi gibi görmek istiyorum. bundan kalıtılan sınıflar burda yazılan kurallara uysunlar istiyorum.
    {
        public DateTime kayitTarih { get; set; }
        public DateTime guncellemeTarih { get; set; }
      
        public TemelSınıf()
        {
            kayitTarih = DateTime.Now; 
            guncellemeTarih = DateTime.Now;
        }
        public void Test()
        {
            Console.WriteLine("TemelSınıf => Test metotu");
        }

        public abstract void testAbstract();  // metot imzası denilen bu kısım yazılır sadece.
        //{
        //}  abstract metotların metot bodyleri yoktur.
    }
}
