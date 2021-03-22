using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace JenkinsTest.UnitTest
{
    public class CalculatorTest
    {
        private Calculator _calculator = new Calculator();

        [Test]
        public void Add_positive_integer()
        {
            SumShouldBe(1, 4, 3);
        }

        private void SumShouldBe(int a, int b, int expected)
        {
            Assert.AreEqual(expected, _calculator.Add(a, b));
        }
    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
