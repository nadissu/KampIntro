using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string [] meyveler = new string[] { };

            //bir class tanılamk için bu kodu kullanmak gerekiyor
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            //type-safe--tip güvenli
            Urun[] urunler = new Urun[] { urun1,urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");

            }

            Console.WriteLine("-----------Metodlar------------");

            //instance--örnek oluşturma
            //encapsulation (ayrı ayrı yazacağımız yapıyı bir düzenin içine dahil etmeye yarar.)
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,7);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,8);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,9);
        }
    }
}


//do not repeat yourself
