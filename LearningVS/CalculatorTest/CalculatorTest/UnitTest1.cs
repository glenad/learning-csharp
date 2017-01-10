using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        private TestStack.White.Application application;
        
        [TestInitialize]
        public void TestSetup()
        {
            string ApplicationPath = "C:\\Windows\\system32\\calc.exe";
            application = TestStack.White.Application.Launch(ApplicationPath);
        }


        [TestMethod]
        public void TestMethod1()
        {
            // Define application Main window
            Window mainWindow = application.GetWindow("Calculator");

            // Click on 2 (Two) button
            TestStack.White.UIItems.Button btnTwo = mainWindow.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByText("2"));
            btnTwo.Click();

            // Click (+) button
            TestStack.White.UIItems.Button btnPlus = mainWindow.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByText("Add"));
            btnPlus.Click();

            // Click on 3 (Three) button
            TestStack.White.UIItems.Button btnThree = mainWindow.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByText("3"));
            btnThree.Click();

            // Click (=) equals button
            TestStack.White.UIItems.Button btnEquals = mainWindow.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByText("Equals"));
            btnEquals.Click();

            // Verify the result is 5
            TestStack.White.UIItems.Label txtResult = mainWindow.Get<TestStack.White.UIItems.Label>(SearchCriteria.ByAutomationId("150"));
            Assert.AreEqual("5", txtResult.Text);

        }

        [TestCleanup]
        public void TearDown()
        {
            application.Close();
        }


    }
}
