using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Librarys.Tests
{
    public class Arrays1DemensionalTests
    {
        
        [TestCase(new int[] { 1, 6, 9, 4}, 1)]
        [TestCase(new int[] { 7, 0, -10, 3 }, -10)]
        [TestCase(new int[] { 9, 15, 0, 6 }, 0)]
        [TestCase(new int[] { -9, -15, 0, -6 }, -15)]
        public void GetMinNumber_Test(int[] array, int expected)
        {
            int actual;
            actual = Arrays1Demensional.GetMinNumber(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void GetMinNumber_NegativeTest(int[] array)
        {
            Assert.Throws<Exception>(() => Arrays1Demensional.GetMinNumber(array));
        }

        [TestCase(new int[] { 1, 6, 9, 4 }, 9)]
        [TestCase(new int[] { 7, 0, -10, 3 }, 7)]
        [TestCase(new int[] { -9, -15, -1, -6 }, -1)]
        [TestCase(new int[] { -9, -15, 0, -6 }, 0)]
        public void GetMaxNumber_Test(int[] array, int expected)
        {
            int actual;
            actual = Arrays1Demensional.GetMaxNumber(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void GetMaxNumber_NegativeTest(int[] array)
        {
            Assert.Throws<Exception>(() => Arrays1Demensional.GetMaxNumber(array));
        }

        [TestCase(new int[] { 1, 6, 9, 4 }, 0)]
        [TestCase(new int[] { 7, 0, -10, 3 }, 2)]
        [TestCase(new int[] { 9, 15, 0, 6 }, 2)]
        [TestCase(new int[] { -9, -15, 0, -6 }, 1)]
        public void GetIndexOfMinNum_Test(int[] array, int expected)
        {
            int actual;
            actual = Arrays1Demensional.GetIndexOfMinNum(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void GetIndexOfMinNum_NegativeTest(int[] array)
        {
            Assert.Throws<Exception>(() => Arrays1Demensional.GetIndexOfMinNum(array));
        }

        [TestCase(new int[] { 1, 6, 9, 4 }, 2)]
        [TestCase(new int[] { 7, 0, -10, 3 }, 0)]
        [TestCase(new int[] { -9, -15, -1, -6 }, 2)]
        [TestCase(new int[] { -9, -15, 0, -6 }, 2)]
        public void GetIndexOfMaxNum_Test(int[] array, int expected)
        {
            int actual;
            actual = Arrays1Demensional.GetIndexOfMaxNum(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void GetIndexOfMaxNum_NegativeTest(int[] array)
        {
            Assert.Throws<Exception>(() => Arrays1Demensional.GetIndexOfMaxNum(array));
        }

        [TestCase(new int[] { 1, 6, 9, 4 }, 10)]
        [TestCase(new int[] { 7, 0, -10, 3 }, 3)]
        [TestCase(new int[] { 9, 15, 0, 6, 1, 4 }, 25)]
        [TestCase(new int[] { -9, -15, 0 }, -15)]
        [TestCase(new int[] {  }, 0)]
        public void SummNumbersWithOddIndex_Test(int[] array, int expected)
        {
            int actual;
            actual = Arrays1Demensional.SummNumbersWithOddIndex(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 6, 9, 4 }, new int[] { 4, 9, 6, 1 })]
        [TestCase(new int[] { 7, 0, -10, 3 }, new int[] { 3, -10, 0, 7 })]
        [TestCase(new int[] { -9, -15, 0 }, new int[] { 0, -15, -9 })]
        [TestCase(new int[] { }, new int[] { })]
        public void ReversArray_Test(int[] array, int[] expected)
        {
            int[] actual;
            actual = Arrays1Demensional.ReversArray(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 6, 9, 4 }, 2)]
        [TestCase(new int[] { 7, 0, -10, 2 }, 1)]
        [TestCase(new int[] { 9, 15, 0, 6, 1, 4 }, 3)]
        [TestCase(new int[] { -9, -15, 0 }, 2)]
        [TestCase(new int[] { }, 0)]
        public void CountOddNumbers_Test(int[] array, int expected)
        {
            int actual;
            actual = Arrays1Demensional.CountOddNumbers(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 6, 9, 4 }, new int[] { 9, 4, 1, 6 })]
        [TestCase(new int[] { 7, 0, -10, 2 }, new int[] { -10, 2, 7, 0 })]
        [TestCase(new int[] { 9, 15, 0, 6, 1, 4 }, new int[] { 6, 1, 4, 9, 15, 0 })]
        [TestCase(new int[] { -9, -15, 0 }, new int[] { 0, -15, -9 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SwipeHalfs_Test(int[] array, int[] expected)
        {
            int[] actual;
            actual = Arrays1Demensional.SwipeHalfs(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 6, 9, 4 }, new int[] { 1, 4, 6, 9 })]
        [TestCase(new int[] { 7, 0, -10, 2 }, new int[] { -10, 0, 2, 7 })]
        [TestCase(new int[] { 9, 15, 0, 6, 1, 4 }, new int[] { 0, 1, 4, 6, 9, 15 })]
        [TestCase(new int[] { -9, -15, 0 }, new int[] { -15, -9, 0 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SortByBubble_Test(int[] array, int[] expected)
        {
            int[] actual;
            actual = Arrays1Demensional.SortByBubble(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 6, 9, 4 }, new int[] { 9, 6, 4, 1 })]
        [TestCase(new int[] { 7, 0, -10, 2 }, new int[] { 7, 2, 0, -10 })]
        [TestCase(new int[] { 9, 15, 0, 6, 1, 4 }, new int[] { 15, 9, 6, 4, 1, 0 })]
        [TestCase(new int[] { -9, -15, 0 }, new int[] { 0, -9, -15 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SortBySelect_Test(int[] array, int[] expected)
        {
            int[] actual;
            actual = Arrays1Demensional.SortBySelect(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
