using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetEvents
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MyButton.Click += MyButton_Click;
        }

        void MyButton_Click(object sender, EventArgs e)
        {
            MyLabel.Text = "Hello World!";
        }

        void MyButton_Click1(object sender, EventArgs e)
        {
            MyLabel.Text = "Some different text";
        }
    }
}