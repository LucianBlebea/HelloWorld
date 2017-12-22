using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using ProductsBusinessLayer;

namespace HelloWorldAPI.Controllers
{
    public class ValuesController : ApiController
    {

        // GET request. Example /api/values/1
        public string GetProductByID(int id)
        {
            //retrieve data for a particular Product
            string productName = ProductBLL.GetProductNameByID(id);

            //return data in json format
            return  productName; 
        }



        // GET api/values
        public IEnumerable<string> GetProductName()
        {
            //return data in json format
            return new string[] { "", "" };
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
