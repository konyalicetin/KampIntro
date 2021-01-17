using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax

        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int StokAdeti)
        {
            Console.WriteLine("Tebrikler sepete eklendi : " + urunAdi);
        }

    }
}
