using System;
using System.Collections.Generic;

namespace PriceListExample
{
    public class ProductList : IShow, IShowM
    {
        private List<ProductItem> _products = new List<ProductItem>();
        private IPriceFormatter _currentFormatter;

        public ProductList()
        {
                
        }

        public ProductList(List<ProductItem> products)
        {
            _products = products;
        }

        public void AddSingleProduct(ProductItem product)
        {
            _products.Add(product);
        }

        public void AddMultipleProducts(IProductItemsProvider productItemsProvider)
        {
            _products.AddRange(productItemsProvider.GetItems());
        }

        public void SetFormatter(IPriceFormatter formatter)
        {
            _currentFormatter = formatter;
        }

        public void Show()
        {
            if (_currentFormatter != null)
            {
                foreach (var product in _products)
                {
                    Console.WriteLine($"{product.Id}, {product.Name}, {_currentFormatter.Format(product.ProductPrice)}");
                }
            }
        }

        public void Show(IPriceFormatter formatter)
        {
            foreach (var product in _products)
            {
                Console.WriteLine($"{product.Id}, {product.Name}, {formatter.Format(product.ProductPrice)}");
            }
        }
    }
}