using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_014
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //DateTime myValue = DateTime.Now;
            //resultLabel.Text = myValue.ToString();
            //resultLabel.Text = myValue.ToLongDateString();
            //resultLabel.Text = myValue.ToShortDateString();

            //resultLabel.Text = myValue.AddDays(2).ToString();
            //resultLabel.Text = myValue.AddMonths(-2).ToLongDateString();
            //resultLabel.Text = myValue.DayOfWeek.ToString();

            //DateTime myValue = DateTime.Parse("1971/12/26");
            DateTime myValue = new DateTime(2005, 10, 28);
            resultLabel.Text = myValue.DayOfWeek.ToString();

        }
    }
}