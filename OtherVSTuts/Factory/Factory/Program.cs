using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {

        // http://www.dotnetperls.com/factory
        // The factory design pattern relies on a type hierarchy. 
        // The classes must all implement an interface or derive from a base class. 
        // We use an abstract class as the base. The Manager, Clerk and Programmer classes derive from Position.

        // The factory design pattern is found in the Factory class. 
        // The point of the Get method is to take a value and instantiate a class based on that value. 
        // It translates integers to objects with a switch statement.

        // Also:
        // Because Manager, Clerk, and Programmer all derive from the same abstract class, 
        // the return type Position can be used.


        // And:
        // An implicit cast automatically casts the Manager, Clerk and Programmer to Position references.


        abstract class Position
        {
            public abstract string Title { get; }

        }

        class Manager : Position
        {
            public override string Title
            {
                get { return "Manager"; }
            }
        }

        class Clerk : Position
        {
            public override string Title
            {
                get { return "Clerk"; }
            }
        }

        class Programmer : Position
        {
            public override string Title
            {
                get { return "Programmer"; }
            }
        }

        static class Factory
        {
            //Decides which class to instantiate
            public static Position Get(int id)
            {
                switch(id)
                {
                    case 0:
                        return new Manager();
                    case 1:
                    case 2:
                        return new Clerk();
                    case 3:
                    default:
                        return new Programmer();
                }
            }
        }


        static void Main()
        {
            for (int i = 0; i <= 3; i++)
            {
                var position = Factory.Get(i);
                Console.WriteLine("where id = {0}, position = {1} ", i, position.Title);
            }
            Console.ReadKey();
        }
    }
}
