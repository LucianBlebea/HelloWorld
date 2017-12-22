using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ProductsBusinessLayer;


namespace HelloWorldAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //retrieve data for a particular Product
            string productName = ProductBLL.GetProductNameByID(1);

            //display title from product to screen
            ViewBag.Title = productName;

            return View();
        }
    }
}
