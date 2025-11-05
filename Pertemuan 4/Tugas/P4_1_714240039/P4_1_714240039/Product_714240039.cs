using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240039
{
    //public class Product_714240039
    //{
    //    //procted string myType = "Book";
    //    //public Product_714240039()
    //    //{
    //    //}


    //    private string myType;
    //    private string myTitle;

    //    public Product_714240039()
    //    {

    //    }

    //    public string MyType
    //    {
    //        get
    //        {
    //            return myType;
    //        }
    //        set
    //        {
    //            myType = value;
    //        }
    //    }
   // }

    //Bagian II
    public abstract class product_714240039
    {
        private string myType;
        private string myTitle;

            public product_714240039()
        {

        }

        //constructor
        public product_714240039(string type, string title)
        {
            myType = type;
            myTitle = title;
        }

        //property untuk MyType
        public string MyType
        {
            get { return myType; }
            set { myType = value; }
        }

        //property untuk MyTitle
        public string MyTitle
        {
            get { return myTitle; }
            set { myTitle = value; }
        }

        //Method abstrak untuk menampilkan info produk
        public abstract void DisplayInfo();
    }

}
