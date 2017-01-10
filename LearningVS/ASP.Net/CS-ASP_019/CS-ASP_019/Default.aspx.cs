using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_019
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            //string result = String.Format("Thank you, {0} for your business", nameTextBox.Text);

            long ss = int.Parse(ssTextBox.Text);
            string result = String.Format("Thank you, {0} for your business. <br /> Your Social Security number is {1:000-00-0000}", nameTextBox.Text, ss);

            resultLabel.Text = result;
        }
    }
}