using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    class Product
    {
        //private variable
        private int id;
        private string productName;
        private double productPrice;

        //property that returns product name, it is set as readonly for now
        public string ProductName
        {
            get
            {
                return productName;
            }
        }

        //property that returns product price, it is set as readonly for now
        public double ProductPrice
        {
            get
            {
                return productPrice;
            }
        }



    }
}
