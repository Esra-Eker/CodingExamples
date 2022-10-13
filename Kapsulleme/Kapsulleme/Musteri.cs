using System;
using System.Collections.Generic;
using System.Text;

namespace Kapsulleme
{
    internal class Musteri
    {
        public Musteri()
        {
            this.id = IDUret();
        }

        // Class => Field
        private int id;
        public int ID
        {
            get 
            { 
                return id; // private içindeki değeri alıp property yardımıyla onu çağıran koda gönderiyor.
            }
            private set
            {
                this.id = value;
            }
        }

        public string isim;
        public string soyisim;


        // Class => property
        private string emailAdres;
        public string EmailAdres
        {
            // get;  // database veya farklı bir veri kaynağı. classı çağıran programcıya datayı gösterdiğimiz kısım.
            // set;  // dış dünyadan alınan datanın içeride private olarak saklanan field içerisine değer atandığı kısım.

            set
            {
                this.emailAdres=value;
            }
            get
            {
                return this.emailAdres;
            }
        }

        private int IDUret()
        {
            Random Rnd = new Random();
            return Rnd.Next(10000, 90000);
        }

        // Odev

        private string _tcKimlikNo;
        public string TcKimlikNo
        {
            get { return _tcKimlikNo.Substring(0,3); }
            set { 
                if(value.Length == 11)
                {
                    bool bayrak = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);
                        if(karakterKontrol)
                        {
                            // sayısal değer demektir.
                        }
                        else
                        {
                            bayrak = true;
                            break;
                        }
                        if(bayrak)
                        {
                            Console.WriteLine("TC kimlik numarası içerisindeki değerler sayısal olmalı..");
                        }
                        else
                        {
                            this._tcKimlikNo = value;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("TC kimlik numarası 11 hane olmalı..");
                }
            }
        }
    }
}
