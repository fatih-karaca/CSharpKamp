using System;

namespace _05OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 0001;
            product1.CategoryId = 01;
            product1.ProductName = "Notebook";
            product1.UnitPrice = 15000;
            product1.StockAmount = 140;

            Product product2 = new Product();
            product2.Id = 0002;
            product2.CategoryId = 01;
            product2.ProductName = "Tablet";
            product2.UnitPrice = 7400;
            product2.StockAmount = 250;

            Product product3 = new Product();
            product3.Id = 0003;
            product3.CategoryId = 02;
            product3.ProductName = "Akıllı Saat";
            product3.UnitPrice = 4750;
            product3.StockAmount = 500;

            Product product4 = new Product { Id = 0004, CategoryId = 02, ProductName = "Kulaklık", UnitPrice=1500, StockAmount=500 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product4,20);
            productManager.Add(product1,50);
            productManager.Add(product3,30);
            productManager.Add(product2,40);
            productManager.Update(product2);
        }
    }
}
