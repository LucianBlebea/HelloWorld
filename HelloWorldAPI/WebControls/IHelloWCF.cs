using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloWorldAPI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHelloWCF" in both code and config file together.
    [ServiceContract]
    public interface IHelloWCF
    {
        [OperationContract]
        string GetProductName();

        [OperationContract]
        string GetProductNameByID(int ID);
    }
}
