using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearchKata;

namespace BinarySearchKataTest
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void WhenArrayIsEmptyReturnsMinusOne()
        {
            var result = BinarySearch.SearchForKeyReturnIndex(1, new int[] { });

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void WhenKeyIsNotInArrayReturnMinusOne()
        {
            var result = BinarySearch.SearchForKeyReturnIndex(1, new int[] { 2 });

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void WhenKeyIsPresentInAListOfLengthOneReturnsOne()
        {
            var result = BinarySearch.SearchForKeyReturnIndex(1, new int[] { 1 });

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void WhenKeyIsInTheMiddleOfAListOfLengthThreeReturnsOne()
        {
            var result = BinarySearch.SearchForKeyReturnIndex(2, new int[] { 1, 2, 3 });

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void WhenKeyIsInTheFirstOfAListOfLengthThreeItReturnsTwo()
        {
            var result = BinarySearch.SearchForKeyReturnIndex(1, new int[] { 1, 2, 3 });

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void WhenKeyIsInTheLastOfAListOfLengthThreeItReturnsTwo()
        {
            var result = BinarySearch.SearchForKeyReturnIndex(3, new int[] { 1, 2, 3 });

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void WhenKeyIs8FromAListOfLength10ItReturns2()
        {
            var result = BinarySearch.SearchForKeyReturnIndex(8, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void WhenKeyIs24OfAListOfLength100ItReturns3()
        {
            var result = BinarySearch.SearchForKeyReturnIndex(24, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                                                                11, 12, 13, 14, 15, 16, 17, 18, 19,
                                                                20, 21, 22, 23, 24, 25, 26, 27, 28, 29,
                                                                30, 31, 32, 33, 34, 35, 36, 37, 38, 39,
                                                                40, 41, 42, 43, 44, 45, 46, 47, 48, 49,
                                                                50, 51, 52, 53, 54, 55, 56, 57, 58, 59,
                                                                60, 61, 62, 63, 64, 65, 66, 67, 68, 69,
                                                                70, 71, 72, 73, 74, 75, 76, 77, 78, 79,
                                                                80, 81, 82, 83, 84, 85, 86, 87, 88, 89,
                                                                90, 91, 92, 93, 94, 95, 96, 97, 98, 99,
                                                                100 });

            Assert.AreEqual(23, result);
        }
    }
}
