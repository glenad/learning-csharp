using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string myValue = superSecretFormula("Jill");
            Console.WriteLine(myValue);
            Console.ReadLine();
        }

        private static string superSecretFormula()
        {
            //stuff goes here
            return "Hello world!";
        }

        private static string superSecretFormula(string name)
        {
            //stuff goes here
            return String.Format("Hello {0}", name);
        }

        private static string superSecretFormula(int number)
        {
            string myValue = number.ToString();
            return String.Format("Hello {0}", myValue);
        }


    }
}
