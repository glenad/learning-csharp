using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;

            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());
            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(3).ToShortTimeString());
            //Console.WriteLine(myValue.AddDays(-3).ToShortDateString());
            //Console.WriteLine(myValue.Month.ToString());

            //DateTime myBirthDay = new DateTime(1965, 11, 23);
            //Console.WriteLine(myBirthDay.ToShortDateString());

            DateTime myBirthDay = DateTime.Parse("26 Dec 1971");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthDay);
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
        }
    }
}
