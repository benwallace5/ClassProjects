using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SearchTryIt
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            SearchService.Service1Client searchService = new SearchService.Service1Client();
            string list = "";

            string result = searchService.search(urlTextBox.Text, fNameTextBox.Text,lNameTextBox.Text);  //search returns not found if not found, otherwise person information using # as delimiter

            if (result !="not found")  //person found
            {
           
                string[] words = result.Split('#');

                if (words.Count() == 7)  //there is no cell provider
                {
                    list = "Encryption:" + words[1]
                        + "\nPassword: " + words[2] + "\nId: " + words[3] + "\nWork: " + words[4] + "\nCell: " + words[5] + "\nProvider: None " + "\nCategory: " + words[6];
                }

                if (words.Count() == 8)  //there is a provider
                {
                    list = "Encryption:" + words[1]
                        + "\nPassword: " + words[2] + "\nId: " + words[3] + "\nWork: " + words[4] + "\nProvider: " + words[5] + "\nCell: " + words[6] + "\nCategory: " + words[7];
                }
                resultLabel.Text = list;
            }
            else
            {
                resultLabel.Text = result;  //not found
            }
        }
    }
}