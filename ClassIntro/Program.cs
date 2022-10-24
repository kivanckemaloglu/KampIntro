using System;
using System.Linq.Expressions;
using System.Transactions;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Kıvanç";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin";
            kurs1.IzlemeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem";
            kurs2.IzlemeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Elon";
            kurs3.IzlemeOrani = 52;

            Kurs[] Kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in Kurslar)
            {
                Console.WriteLine("Foriyaççi : " + kurs.KursAdi + " " + kurs.Egitmen);

            }


            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlemeOrani { get; set; }
    }
}
