using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Store
    {
        Product[] products = new Product[0];

        public void AddProduct(Product product)
        {
            if (!HasProductByNo(product.No))
            {
                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = product;
            }
        }

        public bool HasProductByNo(int no)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].No == no)
                {
                    return true;
                }
            }
            return false;
        }

        public Product GetProductByNo(int no)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].No == no)
                {
                    return products[i];
                }
            }
            throw new ProductNotFoundException($"{no} nomreli mehsul yoxdur.");
        }

        public void ShowProducts()
        {
            foreach (var item in products)
            {
                Console.WriteLine($"Category: {item.Category} - Price: {item.Price}");
            }
        }

       
    }
}
