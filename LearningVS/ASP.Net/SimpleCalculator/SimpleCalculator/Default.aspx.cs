using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            int value1 = int.Parse(firstValue.Text);
            int value2 = int.Parse(secondValue.Text);

            int result;

            result = value1 + value2;
            resultLabel.Text = result.ToString();
        }

        protected void btnSubtract_Click(object sender, EventArgs e)
        {

            int value1 = int.Parse(firstValue.Text);
            int value2 = int.Parse(secondValue.Text);

            int result;

            result = value1 - value2;
            resultLabel.Text = result.ToString();


        }

        protected void btnMultiply_Click(object sender, EventArgs e)
        {

            int value1 = int.Parse(firstValue.Text);
            int value2 = int.Parse(secondValue.Text);

            int result;

            result = value1 * value2;
            resultLabel.Text = result.ToString();
            
        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {

            double value1 = double.Parse(firstValue.Text);
            double value2 = double.Parse(secondValue.Text);

            double result;

            result = value1 / value2;
            resultLabel.Text = result.ToString();

        }


    }
}