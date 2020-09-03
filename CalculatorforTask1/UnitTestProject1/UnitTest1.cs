using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private double a = 673254;
        private double b = 243;
        private double ExpectedResult;
        private double ActualResult;
        private CalculatorforTask1.calculator operation; 

        [TestInitialize]
        public void InitializeUnitTest()
        {
            ExpectedResult = 0.0;
            ActualResult = 0.0;
            operation = new CalculatorforTask1.calculator();
        }

        [TestMethod]
        public void AdditionTest()
        {
            ExpectedResult = a + b;
            ActualResult = operation.Add(a,b);
            Assert.IsTrue(ActualResult == ExpectedResult);
        }

        [TestMethod]
        public void SubtractionTest()
        {
            ExpectedResult = a - b;
            ActualResult = operation.Sub(a, b);
            Assert.IsTrue(ActualResult == ExpectedResult);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            ExpectedResult = a * b;
            ActualResult = operation.Mul(a, b);
            Assert.IsTrue(ActualResult == ExpectedResult);
        }

        [TestMethod]
        public void DivisionTest()
        {
            ExpectedResult = a / b;
            ActualResult = operation.Div(a, b);
            Assert.IsTrue(ActualResult == ExpectedResult);
        }

        [TestMethod]
        public void PercentTest()
        {
            ExpectedResult = a * b / 100;
            ActualResult = operation.Percent(a, b);
            Assert.IsTrue(ActualResult == ExpectedResult);
        }

        [TestMethod]
        public void PowerTest()
        {
            ExpectedResult = Math.Pow(a,b);
            ActualResult = operation.Power(a, b);
            Assert.IsTrue(ActualResult == ExpectedResult);
        }

        [TestMethod]
        public void RootTest()
        {
            ExpectedResult = Math.Pow(a, 1.0/b);
            ActualResult = operation.Root(a, b);
            Assert.IsTrue(ActualResult == ExpectedResult);
        }
    }
}
