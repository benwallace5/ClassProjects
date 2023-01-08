using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace TryIt
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
              XmlTextReader reader = null; 
              try
              {
                  string xmlFileLocation = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data"); //folder location on server to open Persons.xml
                  xmlFileLocation = Path.Combine(xmlFileLocation, "Persons.xml");  //appending Persons.xml to end of the path
                  reader = new XmlTextReader(xmlFileLocation);  //creating a new xmlTextReader object using Persons.xml file path

                  while (reader.Read())
                  {
                      switch (reader.NodeType)
                      {
                          case XmlNodeType.Element:  //element case
                            ListBox1.Items.Add("<" + reader.Name + ">");  //printing <tagName>

                            if (reader.AttributeCount > 0)  //if element contains attributes
                            {
                                while(reader.MoveToNextAttribute())  //while there are more attributes
                                {
                                    ListBox1.Items.Add(reader.Name + "=" + reader.Value);  // add attributeName=Value
                                }
                            }
                            break;
                          case XmlNodeType.Text:  //text case
                              ListBox1.Items.Add(reader.Value);  //printing text content in form <tagName> text </tagName
                              break;
                          case XmlNodeType.EndElement:
                              ListBox1.Items.Add("</" + reader.Name + ">" + "\n");  //printing </tagName>
                              break;
                      }
                  }
              }
              finally
              {
                  reader.Close();
              }
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();  //removing previous xml file
            string xmlFileLocation = urlTextBox.Text;  //pulling url
            XmlTextReader reader = null;

            try
            {
                reader = new XmlTextReader(xmlFileLocation);  //creating a new xmlTextReader object using given url

                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:  //element case
                            ListBox1.Items.Add("<" + reader.Name + ">");  //printing <tagName>

                            if (reader.AttributeCount > 0)  //if element contains attributes
                            {
                                while (reader.MoveToNextAttribute())  //while there are more attributes
                                {
                                    ListBox1.Items.Add(reader.Name + "=" + reader.Value);  // add attributeName=Value
                                }
                            }
                            break;
                        case XmlNodeType.Text:  //text case
                            ListBox1.Items.Add(reader.Value);  //printing text content in form <tagName> text </tagName
                            break;
                        case XmlNodeType.EndElement:
                            ListBox1.Items.Add("</" + reader.Name + ">" + "\n");  //printing </tagName>
                            break;
                    }
                }
            }
            finally
            {
                reader.Close();
            }
        }
    }
}