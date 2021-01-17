using ProductLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib.Views
{
    public class ProductRecordsView
    {
        private Products _products;
        public ProductRecordsView(Products products)
        {
            _products = products;
        }
        public void RunRecordsView()
        {
            Console.WriteLine(ProductCommonOutputText.GetColumnHeadings());
            Console.WriteLine();
            foreach (Product item in _products)
            {
                Console.WriteLine(item);
            }
        }
    }
}
