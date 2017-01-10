using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";


            int highestIndex = 0;
            int lowestIndex = 0;

            // Your Code Here!
            for (int i = 0; i < numbers.Length; i++)
            {
                //highest = (numbers[i] > highest) ? numbers[i] : highest;
                //lowest = (numbers[i] < lowest) ? numbers[i] : lowest;
                if (numbers[i] > numbers[highestIndex])
                {
                    highestIndex = i;
                }
                if (numbers[i] < numbers[lowestIndex]) 
                {
                    lowestIndex = i;
                }


            }

            result = String.Format("Most battles belong to : {0} (Value: {1}) <br />" +
                "Least battles belong to : {2} (Value: {3})",
                names[highestIndex],
                numbers[highestIndex],
                names[lowestIndex],
                numbers[lowestIndex]);

            resultLabel.Text = result;
        }
    }
}