using System;

namespace ClassIntroVeri
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Nadide";
            int yas = 24;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;
            

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;


            //Console.WriteLine(kurs1.KursAdi+ ":" +kurs1.egitmen);
            Kurs[] kurslar = new Kurs[]{kurs1,kurs2,kurs3};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
