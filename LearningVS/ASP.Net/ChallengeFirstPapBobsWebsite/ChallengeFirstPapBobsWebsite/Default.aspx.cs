using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeFirstPapBobsWebsite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

 
        protected void btnPurchase_Click(object sender, EventArgs e)
        {
            lblTotal.Text = "$0.00";

            double dblTotal = 0.00;

            //size
            if (rdbSmallSize.Checked) 
            {
                dblTotal += 10;
            }
            else if (rdbMedSize.Checked)
            {
                dblTotal += 13;
            }
            else 
            {
                dblTotal += 16;
            }

            //crust
            if (rdbDeepDish.Checked)
            {
                dblTotal += 2;
            }

            //topping
            if (chkPepperoni.Checked)
                dblTotal += 1.50;
            
            if (chkOnions.Checked)
                dblTotal += 0.75;
            
            if (chkGreenPeppers.Checked)
                dblTotal += 0.50;
            
            if (chkRedPeppers.Checked)
                dblTotal += 0.75;
            
            if (chkAnchovies.Checked)
                dblTotal += 2.00;

            //discount check
            if ((chkPepperoni.Checked && chkGreenPeppers.Checked && chkAnchovies.Checked)
                || chkPepperoni.Checked && chkRedPeppers.Checked && chkOnions.Checked)
                dblTotal -= 2.00;

            //total
            lblTotal.Text = "$" + dblTotal.ToString();
        }
    }
}