using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    internal class SepetManager
    {
        //Naming covension
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string urunAciklama, double urunFiyat, int urunAdeti)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
