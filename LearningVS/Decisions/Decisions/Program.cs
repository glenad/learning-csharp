using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Type something and press ENTER...");
            //string userInput;
            //userInput = Console.ReadLine();
            //Console.WriteLine("You entered " + userInput);
            //Console.ReadLine();

            //Console.WriteLine("Enter a number 1, 2, or 3");
            //string userValue = Console.ReadLine();
            //string message;
            //if (userValue == "1")
            //    message = "You've won a new car!";
            //else if (userValue == "2")
            //    message = "You've won a new boat!";
            //else if (userValue == "3")
            //    message = "You've won a refurbished cat!";
            //else
            //    message = "Sorry, that did not compute";

            //Console.WriteLine(message);
            //Console.ReadLine();

            Console.WriteLine("Enter a number between 1 and 3");
            string response = Console.ReadLine();
            string message = (response == "1") ? "boogie" : "something else completely";
            Console.WriteLine("You entered: {0}", message);
            Console.ReadLine();

        }
    }
}
