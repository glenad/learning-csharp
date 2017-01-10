using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                calEndDate.SelectedDate = DateTime.Now.Date;
                calStartDate.SelectedDate = calEndDate.SelectedDate.AddDays(14);
                calStartDate.VisibleDate = calStartDate.SelectedDate;
                calProjectedEndDate.SelectedDate = calEndDate.SelectedDate.AddDays(21);
                calProjectedEndDate.VisibleDate = calProjectedEndDate.SelectedDate;
                
                
            }

            //Page.MaintainScrollPositionOnPostBack = true;
        }

        protected void btnAssign_Click(object sender, EventArgs e)
        {

            bool blnError = false;
            string strMessage;
            int intDays = (int)calProjectedEndDate.SelectedDate.Subtract(calStartDate.SelectedDate).TotalDays;
            double dblCost;

            if (calStartDate.SelectedDate.Subtract(calEndDate.SelectedDate).TotalDays < 14)
            {
                blnError = true;
                strMessage = "Error: Must allow at least two weeks between previous assignment and new assignment";
            }

            if (intDays > 21)
            {
                dblCost = (intDays * 500) + 1000;
            }
            else
            {
                dblCost = intDays * 500;
            }

            if (blnError)
            {
                strMessage = "Error: Must allow at least two weeks between previous assignment and new assignment";
            }
            else
            {
                strMessage = String.Format("Assignment of {0} to assignment {1} is authorised. Budget total: {2:C}", 
                    txtCodeName.Text, txtAssignment.Text, dblCost);
            }

            resultLabel.Text = strMessage;






            

                //firstCalendar.SelectedDate.Subtract(secondCalendar.SelectedDate).TotalDays.
        }

        protected void calEndDate_SelectionChanged(object sender, EventArgs e)
        {
            calStartDate.SelectedDate = calEndDate.SelectedDate.AddDays(14);
        }
    }
}