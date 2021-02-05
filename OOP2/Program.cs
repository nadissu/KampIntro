using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "1234";
            musteri1.Adi = "Nadide";
            musteri1.Soyadi = "Sığırtmaç";
            musteri1.TcNo = "123456";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12345";
            musteri2.SirketAdi = "Nadide Şirketleri";
            musteri2.VergiNo = "000";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);
            



            
            //SOLID


        }
    }
}
