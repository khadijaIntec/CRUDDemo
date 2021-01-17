using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib.Models
{
    public class Products:IEnumerable
    {
        List<Product> _products = null;
        public Products()
        {
            _products = new List<Product>();
            SeedData();
        }
        public Product this[int index]
        {
            get
            {
                return _products[index];
            }
        }
        private void SeedData()
        {
            Add(ProductObjectFactory.CreateNewProduct("Coffee", "Warm drinks", 5.00m));
            Add(ProductObjectFactory.CreateNewProduct("Coca-Cola", "Cold drinks", 2.00m));
            Add(ProductObjectFactory.CreateNewProduct("Milk", "Cold drinks", 1.50m));
            Add(ProductObjectFactory.CreateNewProduct("Water", "Cold drinks", 1.00m));
            Add(ProductObjectFactory.CreateNewProduct("Thee", "Warm drinks", 3.15m));
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public IEnumerator GetEnumerator()
        {
            return _products.GetEnumerator();
        }
    }
}
