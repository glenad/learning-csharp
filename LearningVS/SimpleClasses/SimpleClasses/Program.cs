using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();

            myNewCar.Make = "Ford";
            myNewCar.Model = "Escourt";
            myNewCar.Year = 1995;
            myNewCar.Color = "Red";

            Console.WriteLine("{0} - {1} - {2}",
                myNewCar.Make,
                myNewCar.Model,
                myNewCar.Color);

            //double marketValueOfCar = determineMarketValue(myNewCar);

            Console.WriteLine("Car's market value: {0:C}", myNewCar.DetermineMarketValue());

            Console.ReadLine();

        }

        private static double determineMarketValue(Car car)
        {
            double carValue = 100.0;

            //todo: the code here that actually goes and gets the carValue

            return carValue;

        }


    }

    class Car
    {   
        //remember prop tab tab enter enter
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }


        public double DetermineMarketValue()
        {
            double carValue = 100.0;

            if (this.Year > 1989)
                carValue = 10000.0;
            else
                carValue = 2000.0;
            //todo: the code here that actually goes and gets the carValue

            return carValue;
        }

    }


}
