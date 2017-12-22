using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using System.Configuration;

using ProductsBusinessLayer;
using System.Net;

namespace HelloConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //retrieve data directly by calling a method from the business layer
            GetDataDirectly(1);

            //retrieve data by making an HTTP request
            GetDataFromAPI(1);

            //retrieve data by calling WCF webservice
            GetDataFromWCFwebservice(1);

            Console.Write("Finished. Press any key to close.");
            //console to wait for user input before closing
            Console.ReadKey();
        }

        //access data directly from the business and data access layer
        public static void GetDataDirectly(int ID)
        {
            Console.WriteLine("Retreiving data from database.");

            //retrieve data for a particular Product using the Business Layer
            string productName = ProductBLL.GetProductNameByID(1);

            //output to console
            Console.WriteLine(productName);
        }

        //Restful API call
        public static void GetDataFromAPI(int ID)
        {

            string AppSettingsURL = ConfigurationManager.AppSettings[name: "API_URL"] + ID;
          

            //retrieve data by calling the Restful API
            Console.WriteLine("Retreiving data using HTTP request:");

            // Create a request for the URL.   
            WebRequest request = WebRequest.Create(AppSettingsURL);
            // If required by the server, set the credentials.  
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.  
            try
            {
                WebResponse response = request.GetResponse();
                // Display the status.  
                // Console.WriteLine(((HttpWebResponse)response).StatusDescription);

                // Get the stream containing content returned by the server.  
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.  
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.  
                string responseFromServer = reader.ReadToEnd();
                // Display the content.  
                Console.WriteLine(responseFromServer);
                // Clean up the streams and the response.  
                reader.Close();
                response.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not access webservice. Error: '{0}'", e);
            }
        }

        //WCF webservice call
        public static void GetDataFromWCFwebservice(int ID)
        {
            Console.WriteLine("Retreiving data by calling WCF webservice:");

            HelloLucian.HelloWCFService.HelloWCFClient service = new HelloLucian.HelloWCFService.HelloWCFClient();

            string result = "";
            try
            {
                result = service.GetProductNameByID(ID);
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not retrieve data from WCF service. Error: '{0}'", e.InnerException);
            }

            Console.WriteLine(result);
        }


    }
}
