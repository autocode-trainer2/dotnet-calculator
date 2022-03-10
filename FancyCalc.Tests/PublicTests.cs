using System;
using NUnit.Framework;

namespace FancyCalc
{
    [TestFixture]
    public class FancyCalculatorTests
    {

        [Test]
        public void AddTest()
        {
            FancyCalcEnguine calc = new FancyCalcEnguine();
            double expected = 4;
            double actual = calc.Add(2, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 3, ExpectedResult = 9)]
        public double MultiplyTest(int a, int b)
        {
            int c = 10; //useless variable and commented out code
            var calc = new FancyCalcEnguine();
            return calc.Multiply(a, b);
        }
    }
}
