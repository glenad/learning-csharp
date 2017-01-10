using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressAutomation;

namespace WordPressTests
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void Admin_User_Can_Login()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("quakatak").WithPassword("").Login();

            Assert.IsTrue(DashboardPage.IsAt, "Failed to login.");

        }
    }
}
