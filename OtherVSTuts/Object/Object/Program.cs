using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    class Program
    {
        static void Main(string[] args)
        {
            // http://www.dotnetperls.com/object

            ////C# program that uses object
            ////object val = new System.Text.StringBuilder();
            //System.Object val = new System.Text.StringBuilder();
            //Console.WriteLine(val.GetType());

            ////C# program that uses object type argument  
            
            ////string type as object
            //string value = "Dot Net Perls";
            //Test(value);
            //Test((object)value);
            
            ////integer type as object
            //int number = 100;
            //Test(number);
            //Test((object)number);

            ////null object
            //Test(null);

            Console.ReadKey();
        }


        //static void Test(object value)
        //{
        //    Console.WriteLine(value != null);
        //    if (value is string)
        //    {
        //        Console.WriteLine("String value: {0}", value);
        //    }
        //    else if (value is int)
        //    {
        //        Console.WriteLine("Int value: {0}", value);
        //    }
        //}

    }
}
