using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;


namespace WcfXMLService
{
    public class Service1 : IService1
    {
       public string search(string url, string first, string last)  //takes a first and last name(string) as input and returns #Encryption#Password#Id#Work#Provider#Cell#Category
        {
            XmlTextReader reader = null;
            string ret = "";  //return string
            bool validFirstName = false;
            try
            {
                reader = new XmlTextReader(url);  //initiailizing xmlTextReader

                while (reader.Read())  //reading xml file until end
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:  //do nothing in element case
                            break;
                        case XmlNodeType.Text:
                            if (reader.Value == first)
                            {
                                validFirstName = true;  //updating validFirstName bool to true
                            }
                            if (reader.Value == last && validFirstName)  //Found last name and first name was correct, person is found
                            {
                                while (reader.Read())
                                {
                                    switch (reader.NodeType)
                                    {
                                        case XmlNodeType.Element:
                                            if(reader.AttributeCount > 0) //if element contains attributes
                                            {
                                                while (reader.MoveToNextAttribute()) //while there are more attributes
                                                {
                                                    ret += "#" + reader.Value;  //add attributes to return string
                                                }
                                            }
                                            break;
                                        case XmlNodeType.Text:
                                            ret += "#" + reader.Value;  //using # as delimiter
                                            break;
                                        case XmlNodeType.EndElement:
                                            if (reader.Name == "Person")  //end of person element
                                            {
                                                return ret;  //return information
                                            }
                                            break;
                                    }
                                }
                            }
                            break;
                        case XmlNodeType.EndElement:
                            if (reader.Name == "Name")
                            {
                                validFirstName = false;
                            }
                            break;
                    }
                }
            }
            finally
            {
                reader.Close();
            }
            return "not found";
        }
    }
}
