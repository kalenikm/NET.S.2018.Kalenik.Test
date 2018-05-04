using System;
using System.Collections.Generic;

namespace Test6.Solution
{
    public static class CustomEnumerable<T> where T : struct 
    {
        public static IEnumerable<T> Generate(T a1, T a2, int count, Func<T, T, T> func)
        {
            if (count <= 0)
            {
                throw new ArgumentException(nameof(count));
            }

            if (ReferenceEquals(null, func))
            {
                throw new ArgumentNullException($"{nameof(func)} is null.");
            }

            yield return a1;
            yield return a2;
            for (int i = 2; i < count + 2; i++)
            {
                var next = func(a1, a2);

                yield return next;

                a1 = a2;
                a2 = next;
            }
        }
    }
}