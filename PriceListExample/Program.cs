using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;


namespace PriceListExample
{
    class Program
    {
        static void Main()
        {
            List<ProductItem> products = new List<ProductItem>()
            {
                new ProductItem(1, "Product1", new Price(100, 10, "UAH")),
                new ProductItem(2, "Product2", new Price(200, 10, "UAH")),
                new ProductItem(3, "Product3", new Price(300, 27, "USD")),
            };

            ProductList productsList = new ProductList(products);

            productsList.AddSingleProduct(new ProductItem(4, "Product4", new Price(400, 37, "USD")));

            productsList.SetFormatter(new UaPriceFormatter());
            productsList.Show();

            Console.WriteLine("----------------------------------------------------");
            productsList.Show(new UsPriceFormatter());

            Console.WriteLine("----------------------------------------------------");
            productsList.Show(new UaPriceFormatter());
        }
    }
}
