using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Enum
{
    internal class sanalDatabase
    {
        ArrayList sanalDB = new ArrayList();

        public musteriReturnValue musteriYeniKayit(Musteri M)
        {
            // parametre kontrol

            // kayıt kontrol

            sanalDB.Add(M);
            return musteriReturnValue.kayitBasarili;
        }
    }
}
