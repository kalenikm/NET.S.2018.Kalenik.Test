using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Test6.Solution;

namespace Task6.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        private Func<int, int, int> _func1 = ((i1, i2) => i2 + i1);
        private Func<int, int, int> _func2 = ((i1, i2) => 6*i2 - 8*i1);
        private Func<double, double, double> _func3 = ((i1, i2) => i2 + (i1/i2));

        [Test]
        public void Generator_ForSequence1()
        {
            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};
            int[] result = CustomEnumerable<int>.Generate(1, 1, 8, _func1).ToArray();

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            int[] result = CustomEnumerable<int>.Generate(1, 2, 8, _func2).ToArray();

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [Test]
        public void Generator_ForSequence3()
        {
            //                                    4.0575757575757603d expected
            //                                    4.0575757575757576d but was
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            double[] result = CustomEnumerable<double>.Generate(1, 2, 8, _func3).ToArray();

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}
