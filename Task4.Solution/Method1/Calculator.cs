using System;
using System.Collections.Generic;

namespace Task4.Solution.Method1
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, AveragingMethod averagingMethod)
        {
            if (ReferenceEquals(null, values))
            {
                throw new ArgumentNullException(nameof(values));
            }

            return CalculatorMethodFactory.Calculate(values, averagingMethod);
        }
    }
}