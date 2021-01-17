using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductLib.Views;
using ProductLib.Models;

namespace ProductCon
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Products products = new Products();
            ProductRecordsView productRecordsView = ProductObjectFactory.ProductRecordsViewObject(products);

            while (!endApp)
            {
                Console.Clear();
                Console.WriteLine(ProductCommonOutputText.GetApplicationHeading());
                productRecordsView.RunRecordsView();
                Console.WriteLine();
                Console.WriteLine(ProductCommonOutputText.GetInstructions());
                ConsoleKey instructionKey = Console.ReadKey().Key;
                switch (instructionKey)
                {
                    case ConsoleKey.C:
                        ProductCreateView productCreateView = ProductObjectFactory.ProductCreateViewObject(products);
                        productCreateView.RunCreateView();
                        break;
                    case ConsoleKey.R:
                        break;
                    case ConsoleKey.U:
                        break;
                    case ConsoleKey.D:
                        break;
                    default:
                        endApp = true;
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
