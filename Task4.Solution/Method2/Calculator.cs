using System;
using System.Collections.Generic;

namespace Task4.Solution.Method2
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, Func<List<double>, double> func)
        {
            if (ReferenceEquals(null, values))
            {
                throw new ArgumentNullException(nameof(values));
            }

            return func.Invoke(values);
        }
    }
}