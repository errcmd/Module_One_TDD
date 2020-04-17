using CalculatorSample.Logic;
using Moq;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace CalculatorSample.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        private Mock<ILogger> MockInitilizer()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(l => l.Log(It.IsAny<string>())).Callback<string>(s => Debug.WriteLine(s));
            return mock;
        }
        [Test]
        public void Test_Plus_Positive_Numbers()
        {
            Assert.AreEqual(expected: 7, new Calculator(MockInitilizer().Object).Plus(3, 4));
        }
        [Test]
        public void Test_Plus_Negative_Numbers()
        {
            Assert.AreEqual(expected: -7, new Calculator(MockInitilizer().Object).Plus(-3, -4));
        }

        [Test]
        public void Test_Minus_Positive_Numbers()
        {
            Assert.AreEqual(expected: 1, new Calculator(MockInitilizer().Object).Minus(5, 4));
        }

        [Test]
        public void Test_Minus_Negative_Numbers()
        {
            Assert.AreEqual(expected: 1, new Calculator(MockInitilizer().Object).Minus(-3, -4));
        }

        [Test]
        public void Test_Multiply_Positive_Numbers()
        {
            Assert.AreEqual(expected: 6, new Calculator(MockInitilizer().Object).Multiply(2, 3));
        }

        [Test]
        public void Test_Multuply_Negative_Numbers()
        {
            Assert.AreEqual(expected: -6, new Calculator(MockInitilizer().Object).Multiply(-2, 3));
        }

        [Test]
        public void Test_Divide_Positive_Numbers()
        {
            Assert.AreEqual(expected: 2.5, new Calculator(MockInitilizer().Object).Divide(5, 2));
        }

        [Test]
        public void Test_Divide_Negative_Numbers()
        {
            Assert.AreEqual(expected: 4.5, new Calculator(MockInitilizer().Object).Divide(-9, -2));
        }

        [Test]
        public void Test_Divide_Zero()
        {
           Assert.Throws<DivideByZeroException>(() => { new Calculator(MockInitilizer().Object).Divide(1, 0); });
        }

        [Test]
        public void Test_Degree_Positive_Numbers()
        {
            Assert.AreEqual(expected: 4, new Calculator(MockInitilizer().Object).Degree(2, 2));
        }

        [Test]
        public void Test_Degree_Negative_Numbers()
        {
            Assert.AreEqual(expected: -8, new Calculator(MockInitilizer().Object).Degree(-2, 3));
        }

    }
}
