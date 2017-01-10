using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_036
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Car myNewCar = new Car();

            myNewCar.Make = "Oldsmobile";
            myNewCar.Model = "Cutlas Supreme";
            myNewCar.Year = 1986;
            myNewCar.Color = "Silver";

            double myMarketValueOfCar = myNewCar.DetermineMarketValue();

            resultLabel.Text = String.Format("{0} - {1} - {2} - {3} - {4:C}", 
                myNewCar.Make, myNewCar.Model, myNewCar.Year.ToString(), 
                myNewCar.Color, myMarketValueOfCar);

        }

        /*
        private double determineMarketValue(Car car)
        {
            double carValue;
            if (car.Year > 1990)
                carValue = 10000.0;
            else
                carValue = 2000.0;

            return carValue;
        }
        */

    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public double DetermineMarketValue()
        {
            double carValue;
            if (this.Year > 1990)
                carValue = 10000.0;
            else
                carValue = 2000.0;

            return carValue;
        }


    }

}