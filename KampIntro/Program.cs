using System;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type safetyt - tip güvenliği
            //Do not repeat yourself - Kendini tekrar etme.
            string kategoriEtiketi = "Kategori";
            int ogrenciSayis = 320000000;
            double faizOrani = 1.45;
            bool sistemeGirişYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirişYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
