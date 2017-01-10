using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool value = true;

            Assert.IsTrue(value);

        }

        [TestMethod]
        public void CalculateHighestGrade()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(90f);
            book.AddGrade(50f);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(90f, stats.HighestGrade);

        }
    }
}
