using System;
using System.Collections.Generic;
using NUnit.Framework;
using method1 = Task4.Solution.Method1;
using method2 = Task4.Solution.Method2;

namespace Task4.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean_Method1()
        {
            method1.Calculator calculator = new method1.Calculator();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, method1.AveragingMethod.Mean);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian_Method1()
        {
            method1.Calculator calculator = new method1.Calculator();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, method1.AveragingMethod.Median);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMean_Method2()
        {
            method2.Calculator calculator = new method2.Calculator();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, method2.CalculatorMethods.MeanMethod);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian_Method2()
        {
            method2.Calculator calculator = new method2.Calculator();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, method2.CalculatorMethods.MedianMethod);

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}