using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240039
{
    //internal class Product_714240039
    //{
    //    static void Main(string[] args)
    //    {
    //        Product_714240039 myProduct = new Product_714240039();
    //        Console.WriteLine(myProduct.myType);
    //    }
    //}
    class ProductTest_714240039
    {
        static void Main(string[] args)
        {
            //Product_714240039 myProduct = new Product_714240039();

            //Console.WriteLine(myProduct.MyType);

            //Product_714240039 myProduct = new Product_714240039();
            //myProduct.MyType = "DVD";
            //Console.WriteLine(myProduct.MyType);

            //Book_714240039 product1 = new Book_714240039("Book", "C# Programming", "300");
            //product1.DisplayInfo();

            Book_714240039 product1 = new Book_714240039("Book", "C# Programming", "300");
            DVD_714240039 product2 = new DVD_714240039("DVD", "Ethernal Sunshine of the Spotless mind", "145");

            product1.DisplayInfo();
            product2.DisplayInfo();
        }
    }
}
