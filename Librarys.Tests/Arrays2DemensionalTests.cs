using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Librarys.Tests
{
    class Arrays2DemensionalTests
    {
        [TestCase(1, -11)]
        [TestCase(2, -13)]
        [TestCase(3, -8)]
        public void GetMinNumber_Test(int mockNumber, int expected)
        {
            int actual;
            actual = Arrays2Demensional.GetMinNumber(Arrays2DMocks.GetMock(mockNumber));
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void GetMinNumber_NegativeTest(int mockNumber)
        {
            Assert.Throws<Exception>(() => Arrays2Demensional.GetMinNumber(Arrays2DMocks.GetMock(0)));
        }

        [TestCase(1, 12)]
        [TestCase(2, 10)]
        [TestCase(3, 10)]
        public void GetMaxNumber_Test(int mockNumber, int expected)
        {
            int actual;
            actual = Arrays2Demensional.GetMaxNumber(Arrays2DMocks.GetMock(mockNumber));
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void GetMaxNumber_NegativeTest(int mockNumber)
        {
            Assert.Throws<Exception>(() => Arrays2Demensional.GetMaxNumber(Arrays2DMocks.GetMock(0)));
        }

        [TestCase(1, new int[] { 2, 2})]
        [TestCase(2, new int[] { 1, 0 })]
        [TestCase(3, new int[] { 3, 0 })]
        public void FindIndexOfMaxNumber_Test(int mockNumber, int[] expected)
        {
            int[] actual;
            actual = Arrays2Demensional.FindIndexOfMaxNumber(Arrays2DMocks.GetMock(mockNumber));
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void FindIndexOfMaxNumber_NegativeTest(int mockNumber)
        {
            Assert.Throws<Exception>(() => Arrays2Demensional.FindIndexOfMaxNumber(Arrays2DMocks.GetMock(0)));
        }

        [TestCase(1, new int[] { 3, 2 })]
        [TestCase(2, new int[] { 1, 3 })]
        [TestCase(3, new int[] { 3, 1 })]
        public void FindIndexOfMinNumber_Test(int mockNumber, int[] expected)
        {
            int[] actual;
            actual = Arrays2Demensional.FindIndexOfMinNumber(Arrays2DMocks.GetMock(mockNumber));
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void FindIndexOfMinNumber_NegativeTest(int mockNumber)
        {
            Assert.Throws<Exception>(() => Arrays2Demensional.FindIndexOfMinNumber(Arrays2DMocks.GetMock(0)));
        }

        [TestCase(1, 4)]
        [TestCase(2, 3)]
        [TestCase(3, 2)]
        public void CountBiggerNummbers_Test(int mockNumber, int expected)
        {
            int actual;
            actual = Arrays2Demensional.CountBiggerNummbers(Arrays2DMocks.GetMock(mockNumber));
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 4)]
        [TestCase(2, 5)]
        [TestCase(3, 6)]
        public void TransposeArray_Test(int mockNumber, int expectedMockNumber)
        {
            int[,] actual;
            int[,] expected;
            expected = Arrays2DMocks.GetMock(expectedMockNumber);
            actual = Arrays2Demensional.TransposeArray(Arrays2DMocks.GetMock(mockNumber));
            Assert.AreEqual(expected, actual);
        }
    }
}
