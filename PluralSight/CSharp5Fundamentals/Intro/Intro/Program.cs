using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please eneter your name");
            string name = Console.ReadLine();

            Console.WriteLine("How much sleep did you get last night");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            if (hoursOfSleep <= 8)
            {
                Console.WriteLine("You must feel tired");
            }
            else
            {
                Console.WriteLine("You seem well rested");
            }

        }
    }
}
