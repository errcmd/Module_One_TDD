using CalculatorSample.Logic;
using Moq;
using NUnit.Framework;
using System.Diagnostics;

namespace CalculatorSample.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void Test_Plus_Positive_Numbers()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(l => l.Log(It.IsAny<string>())).Callback<string>(s => Debug.WriteLine(s));
            var calc = new Calculator(mock.Object);
            var actual = calc.Plus(3, 4);
            mock.Verify(l => l.Log(It.IsAny<string>()));
            Assert.AreEqual(expected: 7, actual);
        }
        [Test]
        public void Test_Plus_Negative_Numbers()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(l => l.Log(It.IsAny<string>())).Callback<string>(s => Debug.WriteLine(s));
            var calc = new Calculator(mock.Object);
            var actual = calc.Plus(-3, -4);
            Assert.AreEqual(expected: -7, actual);
        }

        [Test]
        public void Test_Minus_Positive_Numbers()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(l => l.Log(It.IsAny<string>())).Callback<string>(s => Debug.WriteLine(s));
            var calc = new Calculator(mock.Object);
            var actual = calc.Minus(5, 4);
            mock.Verify(l => l.Log(It.IsAny<string>()));
            Assert.AreEqual(expected: 1, actual);
        }

        [Test]
        public void Test_Minus_Negative_Numbers()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(l => l.Log(It.IsAny<string>())).Callback<string>(s => Debug.WriteLine(s));
            var calc = new Calculator(mock.Object);
            var actual = calc.Minus(-3, -4);
            Assert.AreEqual(expected: 1, actual);
        }

        [Test]
        public void Test_Multiply_Positive_Numbers()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(l => l.Log(It.IsAny<string>())).Callback<string>(s => Debug.WriteLine(s));
            var calc = new Calculator(mock.Object);
            var actual = calc.Multiply(2, 3);
            mock.Verify(l => l.Log(It.IsAny<string>()));
            Assert.AreEqual(expected: 6, actual);
        }

        [Test]
        public void Test_Multuply_Negative_Numbers()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(l => l.Log(It.IsAny<string>())).Callback<string>(s => Debug.WriteLine(s));
            var calc = new Calculator(mock.Object);
            var actual = calc.Multiply(-2, 3);
            Assert.AreEqual(expected: -6, actual);
        }

        [Test]
        public void Test_Divide_Positive_Numbers()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(l => l.Log(It.IsAny<string>())).Callback<string>(s => Debug.WriteLine(s));
            var calc = new Calculator(mock.Object);
            var actual = calc.Divide(5, 2);
            mock.Verify(l => l.Log(It.IsAny<string>()));
            Assert.AreEqual(expected: 2.5, actual);
        }

        [Test]
        public void Test_Divide_Negative_Numbers()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(l => l.Log(It.IsAny<string>())).Callback<string>(s => Debug.WriteLine(s));
            var calc = new Calculator(mock.Object);
            var actual = calc.Divide(-9, -2);
            Assert.AreEqual(expected: 4.5, actual);
        }

        [Test]
        public void Test_Degree_Positive_Numbers()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(l => l.Log(It.IsAny<string>())).Callback<string>(s => Debug.WriteLine(s));
            var calc = new Calculator(mock.Object);
            var actual = calc.Degree(2, 2);
            mock.Verify(l => l.Log(It.IsAny<string>()));
            Assert.AreEqual(expected: 4, actual);
        }

        [Test]
        public void Test_Degree_Negative_Numbers()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(l => l.Log(It.IsAny<string>())).Callback<string>(s => Debug.WriteLine(s));
            var calc = new Calculator(mock.Object);
            var actual = calc.Degree(-2, 3);
            Assert.AreEqual(expected: -8, actual);
        }

    }
}
