using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace KalitimOdev
{
    internal static class sanalDatabase
    {
        private static ArrayList db = new ArrayList(); // dışarıdan erişilsin ama set edilsin istemiyorum, bu yüzden private yaptım. ve new ArrayList(); diyerek nesneyi örnekledim, yani db yi kullanıma açmış oldum.

        public static void yeniUrunEkle(BaseClass data)
        {
            if (data != null && !string.IsNullOrEmpty(data.barkod))
            {
                db.Add(data);
            }
        }
        public static bool dbBarkodKontrol(string barkod)
        {
            bool kontrolIslemi = false;
            if (db != null && db.Count > 0)
            {
                for (int i = 0; i < db.Count; i++)
                {
                    BaseClass bc = (BaseClass)db[i];
                    if (bc.barkod == barkod)
                    {
                        kontrolIslemi = true;
                    }
                }
            }
            return kontrolIslemi;
        }

    }
}
