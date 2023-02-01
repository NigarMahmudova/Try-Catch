using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Product
    {
        int _totalCount;
        public Product(string category, double price)
        {
            _totalCount++;
            No = _totalCount;
            Category = category;
            Price = price;
        }
        public readonly int No;
        public string Category;
        private double _price;
        public double Price
        {
            get => _price;
            set 
            {
                if (value>=0)
                {
                    _price = value;
                }
            }
        }
    }
}
