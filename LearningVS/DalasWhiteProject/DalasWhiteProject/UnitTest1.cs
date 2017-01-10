using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;

namespace DalasWhiteProject
{
    
    [TestClass]
    public class UnitTest1
    {

        private TestStack.White.Application application;
        [TestInitialize]
        public void TestSetup()
        {
            string ApplicationPath = @"C:\Users\glena\AppData\Local\Apps\2.0\Y2OH77PT.3RB\N4R3Q59E.PG7\dire...app_e1644fb4aae764ab_000e.0008_30da91efbe059e48\dts.exe";
            application = TestStack.White.Application.Launch(ApplicationPath);
        }

        
        [TestMethod]
        public void TestMethod1()
        {
            // Get the Search Screen
            Window mainWindow = application.GetWindow("Search & Queues");

            // Set Hardphone Extension
            TestStack.White.UIItems.TextBox txtHardphoneExt = mainWindow.Get<TestStack.White.UIItems.TextBox>(SearchCriteria.ByAutomationId("txtHardphoneExt"));
            txtHardphoneExt.SetValue("1234");

            Assert.AreEqual("1234", txtHardphoneExt.Text);
            
            TestStack.White.UIItems.Button btnOk = mainWindow.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByAutomationId("btnOk"));
            btnOk.Click();

            // Search for ID Number
            TestStack.White.UIItems.ListBoxItems.ComboBox cboIDNumber = mainWindow.Get<TestStack.White.UIItems.ListBoxItems.ComboBox>(SearchCriteria.ByAutomationId("ctrlIDNumberSearch"));
            cboIDNumber.SetValue("6402195164");

            TestStack.White.UIItems.Button btnSearch = mainWindow.Get<TestStack.White.UIItems.Button>(SearchCriteria.ByAutomationId("btnSearch"));
            btnSearch.Click();

            // Open Customer Application Screen
            //TestStack.White.UIItems.TableItems.TableRow rowCustomer = mainWindow.Get<TestStack.White.UIItems.TableItems.TableRow>(SearchCriteria.ByText("Row 0"));
            TestStack.White.UIItems.TableItems.Table datagrid = mainWindow.Get<TestStack.White.UIItems.TableItems.Table>(SearchCriteria.ByAutomationId("dgSearchResults"));
            TestStack.White.UIItems.TableItems.TableRow rowCustomer = datagrid.Rows[0];
            rowCustomer.DoubleClick();

            Window appWindow = application.GetWindow("DALAS [14.8 - 0] [PREPROD] - Mr Glenville Van Wyk");
            TestStack.White.UIItems.Panel pnlActiveApp = appWindow.Get<TestStack.White.UIItems.Panel>(SearchCriteria.ByAutomationId("DTSActiveApplicationControl"));

            System.Diagnostics.Debug.WriteLine(pnlActiveApp.Text);

            System.Diagnostics.Debug.WriteLine(pnlActiveApp.ToString());

        }

        [TestCleanup]
        public void TearDown()
        {
            //application.Close();
        }

    }
}
