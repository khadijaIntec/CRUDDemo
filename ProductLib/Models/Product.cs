using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib.Models
{
    public class Product
    {
        #region FIELDS&PROPERTIES
        private static int _nextId = 0;
        public int Id { get;}
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        #endregion
        #region CONSTRUCTORS
        public Product()
        {
            _nextId++;
            Id = _nextId;
        }
        public Product(string name, string description , decimal price):this()
        {
            Name = name;
            Description = description;
            Price = price;
        }
        #endregion
        #region METHODS
        public override string ToString()
        {
            return $"{Id.ToString().PadRight(6)}\t{Name.PadRight(15)}\t{Description.PadRight(30)}\t{Price.ToString().PadRight(5)}";
        }
        #endregion
    }
}
