using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Librarys.Tests
{
    class CyclesTests

    {
        [TestCase(3, 4, 81)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(-4, 2, 16)]
        public void RaiseToAPower_Test(int num, int degree, double expected)
        {
            double actual;
            actual = Cycles.RaiseToAPower(num, degree);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, -5)]
        [TestCase(0, -3)]
        [TestCase(0, -1)]
        public void RaiseToAPower_NegativeTest(int num, int degree)
        {
            Assert.Throws<Exception>(() => Cycles.RaiseToAPower(num, degree));
        }

        [TestCase(250, 1000, new int[] { 250, 500, 750, 1000 })]
        [TestCase(30, 100, new int[] { 30, 60, 90 })]
        [TestCase(7, 10, new int[] { 7 })]
        public void GetDivisibleNumbers_Test(int divisor, int number, int[] expected)
        {
            int[] actual;
            actual = Cycles.GetDivisibleNumbers(divisor, number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, 3)]
        [TestCase(2, 1)]
        [TestCase(50, 7)]
        public void CountNumbersWhichSquearsLessA_Test(int number, int expected)
        {
            int actual;
            actual = Cycles.CountNumbersWhichSquearsLessA(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-2)]
        [TestCase(-50)]
        public void CountNumbersWhichSquearsLessA_NegativeTest(int number)
        {
            Assert.Throws<Exception>(() => Cycles.CountNumbersWhichSquearsLessA(number));
        }

        [TestCase(15, 5)]
        [TestCase(-9, 3)]
        [TestCase(50, 25)]
        public void GetMaxDivisor_Test(int number, int expected)
        {
            int actual;
            actual = Cycles.GetMaxDivisor(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void GetMaxDivisor_NegativeTest(int number)
        {
            Assert.Throws<Exception>(() => Cycles.GetMaxDivisor(number));
        }

        [TestCase(5, 30, 6, 90)]
        [TestCase(-9, 3, 5, -5)]
        [TestCase(13, 1, 4, 24)]
        public void GetSumOfDivisors_Test(int range1, int range2, int divisor, int expected)
        {
            int actual;
            actual = Cycles.GetSumOfDivisors(range1, range2, divisor);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 8)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        public void GetFibonacciNumber_Test(int n, int expected)
        {
            int actual;
            actual = Cycles.GetFibonacciNumber(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-20)]
        public void GetFibonacciNumber_NegativeTest(int n)
        {
            Assert.Throws<Exception>(() => Cycles.GetFibonacciNumber(n));
        }

        [TestCase(5, 15, 5)]
        [TestCase(-9, 12, 3)]
        [TestCase(0, -90, 90)]
        public void GetMaxCommonDivisor_Test(int a, int b, int expected)
        {
            int actual;
            actual = Cycles.GetMaxCommonDivisor(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        public void GetMaxCommonDivisor_NegativeTest(int a, int b)
        {
            Assert.Throws<Exception>(() => Cycles.GetMaxCommonDivisor(a, b));
        }

        [TestCase(27, 3)]
        [TestCase(8, 2)]
        [TestCase(125, 5)]
        [TestCase(1, 1)]
        public void GetCubeRoot_Test(double a, double expected)
        {
            double actual;
            actual = Cycles.GetCubeRoot(a);
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestCase(0)]
        [TestCase(-125)]
        public void GetCubeRoot_NegativeTest(double a)
        {
            Assert.Throws<Exception>(() => Cycles.GetCubeRoot(a));
        }

        [TestCase(9, 1)]
        [TestCase(-17239254, 5)]
        [TestCase(125, 2)]
        public void CountOddNumbers_Test(int number, int expected)
        {
            int actual;
            actual = Cycles.CountOddNumbers(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(156, 651)]
        [TestCase(2354, 4532)]
        [TestCase(-8367, -7638)]
        public void ReversNumber_Test(int number, int expected)
        {
            int actual;
            actual = Cycles.ReversNumber(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(13, new int[] { 2, 4, 6, 8, 12 })]
        [TestCase(8, new int[] { 2, 4, 6, 8 })]
        [TestCase(5, new int[] { 2, 4 })]
        public void GetNumbersWithSumOfEvenMoreThenSumOfOdd_Test(int number, int[] expected)
        {
            int[] actual;
            actual = Cycles.GetNumbersWithSumOfEvenMoreThenSumOfOdd(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-5)]
        [TestCase(-14)]
        public void GetNumbersWithSumOfEvenMoreThenSumOfOdd_NegativeTest(int number)
        {
            Assert.Throws<Exception>(() => Cycles.GetNumbersWithSumOfEvenMoreThenSumOfOdd(number));
        }

        [TestCase(123, 486, false)]
        [TestCase(-5867, 9078, true)]
        [TestCase(1480, 97921, true)]
        public void CheckMatchOfNumbers_Test(int a, int b, bool expected)
        {
            bool actual;
            actual = Cycles.CheckMatchOfNumbers(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
