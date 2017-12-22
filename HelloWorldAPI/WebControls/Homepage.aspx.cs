using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ProductsBusinessLayer;

namespace HelloWorldAPI
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //retrieve data for a particular Product
            string productName = ProductBLL.GetProductNameByID(1);

            //display title from product to screen
            lblMessage.Text = productName;
        }
    }

       
}