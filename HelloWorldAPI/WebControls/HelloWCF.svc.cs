using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using ProductsBusinessLayer;

namespace HelloWorldAPI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloWCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HelloWCF.svc or HelloWCF.svc.cs at the Solution Explorer and start debugging.
    public class HelloWCF : IHelloWCF
    {
 
        public string GetProductName()
        {
            //retrieve data for a particular Product
            string productName = ProductBLL.GetProductNameByID(1);

            return productName;
        }


        public string GetProductNameByID(int ID)
        {
            //retrieve data for a particular Product
            string productName = ProductBLL.GetProductNameByID(ID);

            return productName;
        }
    }
}
