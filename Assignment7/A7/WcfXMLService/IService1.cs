using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfXMLService
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string search(string url, string first, string last); //takes a first and last name(string) as input and returns #Encryption#Password#Id#Work#Provider#Cell#Category text values as a string
    }
}
