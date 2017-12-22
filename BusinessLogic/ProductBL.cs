using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataLayer.AppCode.HelloDataSetTableAdapters;

namespace ProductsBusinessLayer
{
   public class ProductBLL
    {

        //retrieve data using TableAdapter
        public static string GetProductNameByID(int ID)
        {
            //initialize tableadapter
            ProductTableAdapter productsAdapter = new ProductTableAdapter();

            string returnedValue = "";

            try
            {
                //access data from database
                string result = "Hello World";

                //get data from database using the tableadapter
                //commented out temporarily until the database is accessible
                // result = (string)productsAdapter.GetProductNameByID(ID);

                if (result != null)
                {
                    returnedValue = result;      
                }
              
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not retrieve data for ID: '{0}'. Error: '{1}'", ID, e);
            }

            return returnedValue;
        }

    }
}
