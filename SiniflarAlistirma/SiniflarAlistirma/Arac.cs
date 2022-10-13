using System;
using System.Collections.Generic;
using System.Text;

namespace SiniflarAlistirma
{
    internal class Arac
    {
        public string Marka;
        public string Model;
        public int ModelYil;
        public decimal Km;
        public int YakitTip;
        public int VitesTip;
        public decimal AlisFiyat;
        public decimal SatisFiyat;
        public decimal MaxIndirimTutar;
        public decimal Fiyat;

        public Arac()
        {

        }
        public Arac(string _marka, string _model)
        {
            Marka = _marka;
            Model = _model;
        }
        public Arac(string _marka, string _model, int _modelYil)
        {
            Marka = _marka;
            Model = _model;
            ModelYil = _modelYil;
        }
        public Arac(string _marka,string _model, int _modelYil, decimal _km)
        {
            Marka = _marka;
            Model = _model;
            ModelYil = _modelYil;
            //Km = _km;
            this.Km = _km;
        }
        public void BilgileriGoruntule()
        {
            Console.WriteLine("Marka {0} - Model {1} - Model Yıl {2}", Marka, Model, ModelYil);
        }
        public void FiyatAta(decimal _fiyat)
        {
            decimal fiyatHesap = SatisFiyat - MaxIndirimTutar;
            if (_fiyat < fiyatHesap)
                Console.WriteLine("Geçersiz fiyat girişi yaptınız!");
            else
            {
                this.Fiyat = _fiyat;
                Console.WriteLine("Fiyat güncellendi");
            }
        }
    }
}
