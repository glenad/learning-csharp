using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM2.Database.Test
{
    [TestClass()]
    public class CustomerRetrieveTest : SqlDatabaseTestClass
    {

        public CustomerRetrieveTest()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction CustomerRetrieveTestFound_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRetrieveTest));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction CustomerRetrieveTestNotFound_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition1;
            this.CustomerRetrieveTestFoundData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.CustomerRetrieveTestNotFoundData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            CustomerRetrieveTestFound_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            checksumCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            CustomerRetrieveTestNotFound_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            emptyResultSetCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            // 
            // CustomerRetrieveTestFound_TestAction
            // 
            CustomerRetrieveTestFound_TestAction.Conditions.Add(rowCountCondition1);
            CustomerRetrieveTestFound_TestAction.Conditions.Add(checksumCondition1);
            resources.ApplyResources(CustomerRetrieveTestFound_TestAction, "CustomerRetrieveTestFound_TestAction");
            // 
            // CustomerRetrieveTestFoundData
            // 
            this.CustomerRetrieveTestFoundData.PosttestAction = null;
            this.CustomerRetrieveTestFoundData.PretestAction = null;
            this.CustomerRetrieveTestFoundData.TestAction = CustomerRetrieveTestFound_TestAction;
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 2;
            // 
            // checksumCondition1
            // 
            checksumCondition1.Checksum = "2031155391";
            checksumCondition1.Enabled = true;
            checksumCondition1.Name = "checksumCondition1";
            // 
            // CustomerRetrieveTestNotFoundData
            // 
            this.CustomerRetrieveTestNotFoundData.PosttestAction = null;
            this.CustomerRetrieveTestNotFoundData.PretestAction = null;
            this.CustomerRetrieveTestNotFoundData.TestAction = CustomerRetrieveTestNotFound_TestAction;
            // 
            // CustomerRetrieveTestNotFound_TestAction
            // 
            CustomerRetrieveTestNotFound_TestAction.Conditions.Add(emptyResultSetCondition1);
            resources.ApplyResources(CustomerRetrieveTestNotFound_TestAction, "CustomerRetrieveTestNotFound_TestAction");
            // 
            // emptyResultSetCondition1
            // 
            emptyResultSetCondition1.Enabled = true;
            emptyResultSetCondition1.Name = "emptyResultSetCondition1";
            emptyResultSetCondition1.ResultSet = 1;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion


        [TestMethod()]
        public void CustomerRetrieveTestFound()
        {
            SqlDatabaseTestActions testActions = this.CustomerRetrieveTestFoundData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void CustomerRetrieveTestNotFound()
        {
            SqlDatabaseTestActions testActions = this.CustomerRetrieveTestNotFoundData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        private SqlDatabaseTestActions CustomerRetrieveTestFoundData;
        private SqlDatabaseTestActions CustomerRetrieveTestNotFoundData;
    }
}
