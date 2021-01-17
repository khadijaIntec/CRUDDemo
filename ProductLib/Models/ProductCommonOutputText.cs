using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib.Models
{
    public class ProductCommonOutputText
    {
        public static string GetColumnHeadings()
        {
            string id = "Id";
            string name = "Name";
            string desciription = "Description";
            string price = "Price";
            string heading = $"{id.PadRight(6)}\t{name.PadRight(15)}\t{desciription.PadRight(30)}\t{price}";
            return heading;
        }
        private static string GetUnderlineForHeading(string heading)
        {
            return new string('_', heading.Length -1);
        }
        public static string GetApplicationHeading()
        {
            string heading="Product CRUD Application";
            string underline = GetUnderlineForHeading(heading);
            return $"{heading}\n{underline}";
        }
        public static string GetInstructions()
        {
            return "Geef C/R/U/D";
        }
    }
}
