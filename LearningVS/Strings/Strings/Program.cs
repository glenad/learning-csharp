﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "Go to your c:\\ drive";
            //string myString = "My \"so called\" life";
            //string myString = "What if I need a \nnew line?";
            //string myString = string.Format("{0}", "Bonzai");
            //string myString = string.Format("Make: {0}, Model {1}", "BMW", "760i");
            //string myString = string.Format("{0:C}", 123.45);
            //string myString = string.Format("{0:N}", 1234567890);
            //string myString = string.Format("{0:P}", 0.125);
            //string myString = string.Format("{0: (###) ###-####}", 1234567890);

            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
                       
            */ 

            /*
            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
			{
                myString.Append("--");
                myString.Append(i);
			}
            */

            string myString = "  That summer we took threes across the board  ";
            //myString = myString.Substring(5, 14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            myString = String.Format("Length before {0}, length after {1}",
                myString.Length,
                myString.Trim().Length);

            Console.WriteLine(myString);
            Console.ReadLine();

        }
    }
}
