using ProductLib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib.Models
{
    public class ProductObjectFactory
    {
        private static ProductCreateView productCreateView = null;
        public static Product CreateNewProduct(string name, string description, decimal price)
        {
            return new Product(name, description, price);
        }
        public static ProductRecordsView ProductRecordsViewObject(Products products)
        {
            return new ProductRecordsView(products);
        }
        public static ProductCreateView ProductCreateViewObject(Products products)
        {
            if (productCreateView == null)
            {
                productCreateView = new ProductCreateView(products);
            }
            return productCreateView;
        }
    }
}
