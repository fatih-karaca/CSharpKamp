using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace _03Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 22.50;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 39.90;
            product2.Aciklama = "Diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Adi + " --- " + product.Fiyati + " TL (" + product.Aciklama + ")");
            }

            Console.WriteLine("\n----------- Metotlar -----------");

            ShoppingCartManager cartManager1 = new ShoppingCartManager();
            cartManager1.Add(product1);
            cartManager1.Add(product1);
            cartManager1.Add(product2);
            cartManager1.Remove(product1);
        }
    }
}