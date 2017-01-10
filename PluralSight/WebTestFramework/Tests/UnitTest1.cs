using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebTestFramework;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanGoToHomePage()
        {
            Pages.HomePage.Goto();
            Assert.IsTrue(Pages.HomePage.IsAt());
        }

        [TestCleanup]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}
