using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Metotlar
{
    class Urun
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyat { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

    }
}
