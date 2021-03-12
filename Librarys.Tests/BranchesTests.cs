using NUnit.Framework;
using System;

namespace Librarys.Tests
{
    public class BranchesTests
    {
        [TestCase(-6, -3, -3)]
        [TestCase(4, 9, -5)]
        [TestCase(0, 5, -5)]
        [TestCase(-4, 8, -12)]
        public void GetDifferenceOrProductTest(int a, int b, int expected)
        {
            int actual;
            actual = Branches.GetDifferenceOrProduct(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 3, 1)]
        [TestCase(-4, 9, 2)]
        [TestCase(-3, -5, 3)]
        [TestCase(4, -8, 4)]
        [TestCase(-4, 0, 0)]
        public void GetQuarterTest(int x, int y, int expected)
        {
            int actual;
            actual = Branches.GetQuarter(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 3, 0, new int[3] { 0, 3, 6})]
        [TestCase(-4, 9, 2, new int[3] { -4, 2, 9 })]
        [TestCase(0, -5, 3, new int[3] { -5, 0, 3 })]
        public void SortThreeNumbersTest(int a, int b, int c, int[] expected)
        {
            int[] actual;
            actual = Branches.SortThreeNumbers(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-5, 8, 3, new double[2] { -0.314, 1.914 })]
        [TestCase(7, 0, -3, new double[2] { 0.655, -0.655 })]
        [TestCase(1, 8, 16, new double[1] { -4 })]
        public void GetXOfQuadraticEquationTest(double a, double b, double c, double[] expected)
        {
            double[] actual;
            actual = Branches.GetXOfQuadraticEquation(a, b, c);
            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], 0.001);
            }
            
        }

        [TestCase(1, 4, 5)]
        [TestCase(-2, 3, -3)]
        [TestCase(3, 10, 10)]
        public void GetXOfQuadraticEquation_NegativeTest(double a, double b, double c)
        {
            Assert.Throws<Exception>(() => Branches.GetXOfQuadraticEquation(a, b, c));

        }

        [TestCase(15, "пятнадцать")]
        [TestCase(28, "двадцать восемь")]
        [TestCase(80, "восемьдесят")]
        [TestCase(-23, "минус двадцать три")]
        public void ConvertNumberToTextTest(int number, string expected)
        {
            string actual;
            actual = Branches.ConvertNumberToText(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-3)]
        [TestCase(0)]
        [TestCase(115)]
        public void ConvertNumberToText_NegativeTest(int number)
        {
            Assert.Throws<Exception>(() => Branches.ConvertNumberToText(number));
        }
    }
}
