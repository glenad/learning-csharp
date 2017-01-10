﻿using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressAutomation
{
    public class LoginPage
    {
        public static void GoTo()
        {
            var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://wordpress.com/wp-login.php");
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }

    }

    public class LoginCommand
    {
        private readonly string userName;
        private string password;

        public LoginCommand(string userName)
        {
            this.userName = userName;
        }

        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void Login()
        { 

        }
    }

}
