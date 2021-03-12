using NUnit.Framework;
using System;

namespace Librarys.Tests
{
    public class VarriablesTests
    {
        [TestCase(-6, -3, -7)]
        [TestCase(4, 9, 20.2)]
        [TestCase(0, 5, 5)]
        public void EvaluateTheExpressionTest(double a, double b, double expected)
        {
            double actual;

            actual = Varriables.EvaluateTheExpression(a, b);

            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestCase(-6, -6)]
        [TestCase(4, 4)]
        [TestCase(0, 0)]
        public void EvaluateTheExpression_NegativeTest(double a, double b)
        {
            Assert.Throws<Exception>(() => Varriables.EvaluateTheExpression(a, b));
        }

        [TestCase(10, 3, new int[] { 3, 1 })]
        [TestCase(0, 5, new int[] { 0, 0 })]
        [TestCase(-8, 6, new int[] { -1, -2 })]
        public void DivideWithTheRemainderTest(int a, int b, int[] expected)
        {
            int[] actual;

            actual = Varriables.DivideWithTheRemainder(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 0)]
        [TestCase(0, 0)]
        [TestCase(-8, 0)]
        public void DivideWithTheRemainder_NegativeTest(int a, int b)
        {
            Assert.Throws<Exception>(()=>Varriables.DivideWithTheRemainder(a, b));
        }

        [TestCase(5, 0, 8, 1.6)]
        [TestCase(5, 10, 3, -1.4)]
        [TestCase(-8, 9, 1, 1)]
        public void SolveLinearEquationTest(double a, double b, double c, double expected)
        {
            double actual;
            actual = Varriables.SolveLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual, 0.001);
            
        }

        [TestCase(0, 0, 8)]
        [TestCase(0, 10, 3)]
        [TestCase(0, 9, 1)]
        public void SolveLinearEquation_NegativeTest(double a, double b, double c)
        {
            Assert.Throws<Exception>(()=>Varriables.SolveLinearEquation(a, b, c));
        }

        [TestCase(0, 76, 4, 9, "Y = -16,75X + 76")]
        [TestCase(8, 4, 0, -8, "Y = 1,5X + -8")]
        [TestCase(-6, 0, 0, 9, "Y = 1,5X + 9")]
        public void GetEquationOfStraightLineTest(double x1, double y1, double x2, double y2, string expected)
        {
            string actual;
            actual = Varriables.GetEquationOfStraightLine(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 76, 0, 9)]
        [TestCase(8, 4, 8, -8)]
        [TestCase(-6, 0, -6, 9)]
        public void GetEquationOfStraightLine_NegativeTest(double x1, double y1, double x2, double y2)
        {
            Assert.Throws<Exception>(() => Varriables.GetEquationOfStraightLine(x1, y1, x2, y2));
        }

        [TestCase(0, 5, 5, 0)]
        [TestCase(-8, 0, 0, -8)]
        [TestCase(-6, 9, 9, -6)]
        public void SwapVarsTest(int a, int b, int expectedA, int expectedB)
        {
            int actualA;
            int actualB;
            Varriables.SwapVars(ref a, ref b);
            actualA = a;
            actualB = b;
            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
        }
    }
}