using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Gökhan";
            int yas = 25;

            Kurs kurs1  =   new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Gökhan ÇAKICI";
            kurs1.IzlenmeOrani = 75;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem";
            kurs2.IzlenmeOrani = 63;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Mahmut";
            kurs3.IzlenmeOrani = 82;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " : " + kurs.IzlenmeOrani);
            }
            //Console.WriteLine("Hello Word!");
        }
    }

    class Kurs
    {
        public string   KursAdi { get; set; }
        public string   Egitmen { get; set; }
        public int   IzlenmeOrani { get; set; }
    }
}
