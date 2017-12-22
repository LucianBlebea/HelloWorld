# HelloWorld Exercise

This Hello World program solution is made up of 5 projects:
1.DataLayer, 2.BusinessLogic, 3.HelloWorldAPI, 4.HelloWorldAPI.Tests, 5.ConsoleProject

Each project is explained below:

1.DataLayer Project: 
I created AppCode/HelloDataSet.xsd which accesses the database directly by using TableAdapters.
I also created AlternativeDataAccess.cs to be able to access the data in other ways without TableAdapters, using SQLConnection with a query or by calling a stored procedure.
The connectionString for the SQL database is stored in App.Config.

2.BusinessLogic Project:
Contains a Product.cs class which describes a Product (base class).
Contains a Computer.cs class describes a Computer, which inherits from the Product class.
Contains a ProductBL.cs class, that contains the business logic with a function GetProductNameByID, that accesses the data from the Data Layer by instantiating the tableAdapter. The call to the tableAdapter is commented out, since the tableAdapter points to a database, which I setup on my own computer, but is not included for the purposes of this program.

3.HelloWorldAPI:
This is a .net Web API, which is separated from the program logic,  where I created 4 different ways to access the data:
-using Restful API, programmed in MVC located at Controllers/ValuesController.cs. To see the results, run the project and in the web browser access this link: http://localhost:57321/api/values/1 .Your localhost:portnumber might be different than mine.
-using WCF web service API, located at WebControls/HelloWCF.svc
-using the traditional .net web service API (ASMX) located at WebControls/HelloWebService.asmx
-using a webform that displays the message to the screen, located at WebControls/Homepage.aspx
ConnectionString and settings are stored in Web.config.

4.HelloWorldAPI.Tests:
This is a simple Unit Test located at Controllers/HelloWorldTest.cs, which tests to make sure the Restful API returns the expected result.

5.ConsoleProject:
This console application runs a program that contains logic to access the data using the HelloWorldAPI mentioned above. It is called Program.cs, and it retrieves the data using different ways and displays Hello World on the screen for each successful method call.
Thse methods are explained below:
GetDataDirectly() accesses the data through the Business Layer method.
GetDataFromAPI() creates an HTTP request to access the Restful service API and retrieve the data.
GetDataFromWCFwebservice() calls the WCF webservice (added as a Service Reference to the project) and retrieves the data.
The App.config file contains the settings and URL to the API.

Thanks for reviewing my solution.
Lucian Blebea

