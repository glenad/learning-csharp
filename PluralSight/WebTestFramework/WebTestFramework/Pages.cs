using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTestFramework
{
    public static class Pages
    {

        public static class HomePage
        {
            static string Url = "http://pluralsight.com";
            static string PageTitle = "Pluralsight | Unlimited, online training for IT, Developer and Creative pros";

            public static void Goto()
            {
                Browser.Goto(Url);
            }

            

            public static bool IsAt()
            {
                return Browser.Title == PageTitle;
            }
        }

    }



}
