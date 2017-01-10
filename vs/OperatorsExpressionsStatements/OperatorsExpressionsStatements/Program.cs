using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y, a, b;
            string z = "";

            //Assignment operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            //There are many mathematical operators...

            //Addition
            x = 3 + 4;

            //Subtraction
            x = 4 - 3;

            //Multiplication
            x = 10 * 5;

            //Division
            x = 10 / 5;

            //Operators used to evaluate values

            //Equality 
            if (x == y)
            {
            }

            //Greater than operator
            if (x > y)
            {
            }

            //Less than operator
            if (x < y)
            {
            }

            //Greater or equal than operator

            //Less or equal than operator

            //Conditional AND operator
            if ((x > y) && (a > b))
            {
            }

            //Conditional OR operator
            if ((x > y) || (a > b))
            {
            }

            //In-line conditional operator
            string message = (x == 1) ? "Car" : "Boat";

            //Member access and method invocation
            Console.WriteLine("Hi");

            if (x == y) z = "Bob";

            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
