using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ZadacaEdukos
{
    class Product
    {
        public string Name { get; private set; } 
        public string Price { get; private set; } 
        public bool InStock { get; set; } 

        public Product(string name, string price)
        {
            this.Name = name;
            this.Price = price;
            this.InStock = false;
        }
    }

    class ProductManager    
    {
        List<Product> products; 

        public ProductManager(List<Product> products) 
        {
            this.products = products;
        }

        public void MakeAvailable(Product targetProduct)
        {
            foreach (Product product in products)
            { 
                if (targetProduct == product)
                    product.InStock = true;
            }
        }
        public void RemoveSoldOut()
        { 
            products.RemoveAll(product => product.InStock == false);
        }
    }
}
