using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductLib.Models;

namespace ProductLib.Views
{
    public class ProductCreateView
    {
        private Products _products;
        public ProductCreateView(Products products)
        {
            _products = products;
        }
        public void RunCreateView()
        {
            string name = null;
            string description = null;
            decimal price = 0;
            Console.Clear();
            Console.WriteLine(ProductCommonOutputText.GetApplicationHeading());
            Console.WriteLine();
            Console.WriteLine(ProductCommonOutputText.GetColumnHeadings());
            Console.WriteLine();
            Console.Write("Product Name: ");
            name = Console.ReadLine();
            Console.Write("Product Description: ");
            description = Console.ReadLine();
            Console.Write("Product Price: ");
            price = decimal.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please press S to save product in database");
            ConsoleKey consoleKey = Console.ReadKey().Key;
            if (consoleKey == ConsoleKey.S)
            {
                _products.Add(ProductObjectFactory.CreateNewProduct(name, description, price));
            }
        }
    }
}
