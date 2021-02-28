using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete Eklendi : "+ product.Adi);
        }
        public void Ekle2(string UrunAdi, string Aciklama, int Fiyat) 
        {
            Console.WriteLine("Sepete Eklendi : " + UrunAdi + Aciklama + Fiyat);

        }
    }
}
