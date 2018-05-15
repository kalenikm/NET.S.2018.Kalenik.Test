using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4.Solution.Method1
{
    static class CalculatorMethodFactory
    {
        public static double Calculate(List<double> values, AveragingMethod method)
        {
            switch (method)
            {
                case AveragingMethod.Mean:
                    return MeanMethod(values);
                case AveragingMethod.Median:
                    return MedianMethod(values);
                default:
                    throw new ArgumentException();
            }
        }

        private static double MeanMethod(List<double> values)
        {
            return values.Sum() / values.Count;
        }

        private static double MedianMethod(List<double> values)
        {
            var sortedValues = values.OrderBy(x => x).ToList();

            int n = sortedValues.Count;

            if (n % 2 == 1)
            {
                return sortedValues[(n - 1) / 2];
            }

            return (sortedValues[sortedValues.Count / 2 - 1] + sortedValues[n / 2]) / 2;
        }
    }
}