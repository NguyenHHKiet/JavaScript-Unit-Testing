using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;
using System.Security.Permissions;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation c;
        [TestInitialize] // thiet lap du lieu dung chung cho TC
        public void SetUp()
        {
            c = new Calculation(10, 5);
        }
        [TestMethod] //TC1: a =10, b = 5, kq= 15
        public void Test_Cong()
        {
            int expected, actual;
            // Caculation c = new Caculation(a,b);
            expected = 15;
            actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }
        // sv thực hiện tiếp cho các TC tiếp theo……
        [ExpectedException(typeof(DivideByZeroException))]
        [TestMethod]
        public void Test_ChiaZero()
        {
            int expected, actual;
            expected = 10;
            c = new Calculation(10, 1);
            actual = c.Execute("/");
            Assert.AreEqual(expected, actual);
        }
        public TestContext TestContext { get; set; }

        // Liên kết TestData với project
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential )]
        [TestMethod]
        public void TestWithDataSource()
        {
            int a, b, expected, actual;
            string operation;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            operation = TestContext.DataRow[2].ToString();
            operation = operation.Remove(0, 1);
            
            expected = int.Parse(TestContext.DataRow[3].ToString());

            c = new Calculation(a, b);
            actual = c.Execute(operation);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPower()
        {
            int n;
            double actual;
            double x, expected;
            n = 0;
            x = 2;
            expected = 1;
            actual = Calculation.Power(x, n);
            Assert.AreEqual(expected, actual);

        }
    }
}
