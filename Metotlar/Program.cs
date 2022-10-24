using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya elması";
            urun1.StokAdedi = 50;

            Urun urun2 = new Urun();

            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır elması";


            Urun[] urunler = new Urun[] {urun1,urun2 };


            //type-safe  -- tip güvenli

            foreach (var urun in urunler)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");
                Console.WriteLine("");
            }


            Console.WriteLine("------- Metodlar -------");

            // instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Elma", "Yeşil", 20, 1);
            sepetManager.Ekle2("Armut", "Mavi", 30, 1);
            sepetManager.Ekle2("Karpuz", "Mor", 50, 1);
        }
    }
}



// Tekrar tekrar kullanılabilirliliği sağlayan bir ortam sunar. Do not repeat yourself.
// DRY - Clean Code - Best Practice