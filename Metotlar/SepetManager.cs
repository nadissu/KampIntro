using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //operayonların tutulduğu yer.
        //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi " + urun.Adi);
        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat,int StokAdedi)
        {
            Console.WriteLine("Sepete Eklendi " + urunAdi);
        }
    }
}
