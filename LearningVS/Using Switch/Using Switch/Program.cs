using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Switch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the name of a super hero!");
            string userValue = Console.ReadLine();

            switch (userValue.ToUpper())
	        {
                case "BATMAN" :
                    Console.WriteLine("The caped crusader");
                    break;

                case "SUPERMAN" :
                    Console.WriteLine("Man of Steel");
                    break;

                case "GREENLANTERN" :
                    Console.WriteLine("Emerald fruitbat");
                    break;
                
                default:
                    Console.WriteLine("Does not compute!");
                    break;
	        }
            Console.ReadLine();

        }
    }
}
