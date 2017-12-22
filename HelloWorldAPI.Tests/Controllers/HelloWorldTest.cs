using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldAPI;
using HelloWorldAPI.Controllers;

namespace HelloWorldAPI.Tests.Controllers
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void GetProductByID()
        {
            // declare controller
            ValuesController controller = new ValuesController();

            int testValue = 1;

            // get data from controller by passing in ID
            string result = controller.GetProductByID(testValue);

            // check result exists
            Assert.IsNotNull(result);

            // check the result is as expected
            Assert.AreEqual("Hello World", result);
            
        } 

        [TestMethod]
        public void Post()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
