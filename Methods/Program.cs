using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prodact1 = new Product();
            prodact1.Adi = "Elma";
            prodact1.Fiyat = 15;
            prodact1.Aciklama = "Amasya elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyat = 80;
            product2.Aciklama = "Diyarbakır karpuzu";

            Product[] products= new Product[] {prodact1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyat);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("--------------------------");

            }

            Console.WriteLine("---------Metotlar------");
            BasketManager basketManager = new BasketManager();
            basketManager.Ekle(prodact1);
            basketManager.Ekle(product2);

            basketManager.Ekle2("Armut", "yeşil armut", 12);
            basketManager.Ekle2("Elma", "yeşil elma", 8);
        }
    }
}
