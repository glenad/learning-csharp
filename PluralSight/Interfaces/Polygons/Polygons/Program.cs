using System;
using Polygons.Library;

namespace Polygons
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            DisplayPolygon("Square", square);

            var triangle = new Triangle(5);
            DisplayPolygon("Triangle", triangle);

            var octagon = new Octagon(5);
            DisplayPolygon("Octagon", octagon);

            Console.Read();
        }

        private static void DisplayPolygon(string polygonType, dynamic square)
        {
            Console.WriteLine("{0} Number of Sides: {1}", polygonType, square.NumberOfSides);
            Console.WriteLine("{0} Side Length: {1}", polygonType, square.NumberOfSides);
            Console.WriteLine("{0} Perimeter: {1}", polygonType, square.GetPerimeter());
            Console.WriteLine("{0} Area: {1}", polygonType, square.GetArea());
            Console.WriteLine();
        }


    }
}
