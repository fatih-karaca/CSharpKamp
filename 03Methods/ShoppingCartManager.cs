using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Methods
{
    class ShoppingCartManager
    {
        public void Add(Product product) 
        {
            Console.WriteLine(product.Adi + " sepete eklendi.");        
        }

        public void Remove(Product product)
        {
            Console.WriteLine(product.Adi + " sepetten çıkarıldı.");
        }
    }
}