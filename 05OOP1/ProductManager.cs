using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05OOP1
{
    internal class ProductManager
    {
        public void Add(Product product, int x)
        {
            Console.WriteLine(x + " adet " + product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
    }
}
