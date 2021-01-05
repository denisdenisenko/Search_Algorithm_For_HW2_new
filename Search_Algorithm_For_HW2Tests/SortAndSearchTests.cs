using Microsoft.VisualStudio.TestTools.UnitTesting;
using Search_Algorithm_For_HW2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Algorithm_For_HW2.Tests
{
    [TestClass()]
    public class SortAndSearchTests
    {

        [TestMethod()]
        public void SortAlgorithmTest()
        {
            int[] notSortedArray = { 5, 4, 3, 2, 1 };
            int[] sortedArray = { 1, 2, 3, 4, 5 };
            int[] notSortableArray = { 3, 3, 3, 3, 3, 3, 3 };

            SortAndSearch.SortAlgorithm(ref notSortedArray);
            Assert.IsTrue(sortedArray.SequenceEqual(notSortedArray));
            Assert.IsFalse(notSortableArray.SequenceEqual(sortedArray));
        }

        [TestMethod()]
        public void FirstSearchTest()
        {
            int[] exampleArray = { 6, 9, 52, -20, 100 };
            int firstValueToFind = 0;
            int secondValueToFind = -20;
            int thirdValueToFind = 100;
            int returnedIndex1 = SortAndSearch.FirstSearch(exampleArray, firstValueToFind);
            Assert.AreEqual(returnedIndex1, -1);
            int returnedIndex2 = SortAndSearch.FirstSearch(exampleArray, secondValueToFind);
            Assert.AreEqual(returnedIndex2, 0);
            int returnedIndex3 = SortAndSearch.FirstSearch(exampleArray, thirdValueToFind);
            Assert.AreEqual(returnedIndex3, 4);
        }

        [TestMethod()]
        public void helpingSearchTest()
        {
            int[] exampleArray = { 1, 2, 3, 4, 5 };
            int searchValue1 = 2;
            int searchValue2 = 0;
            int left = 0;
            int right = exampleArray.Length;
            int returnedIndex = SortAndSearch.helpingSearch(exampleArray, searchValue1, left, right);
            Assert.AreEqual(returnedIndex, 1);
            int returnedIndex2 = SortAndSearch.helpingSearch(exampleArray, searchValue2, left, right);
            Assert.AreEqual(returnedIndex2, -1);
        }

        [TestMethod()]
        public void SecondSearchTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ThirdSearchTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DisplayElementsTest()
        {
            Assert.Fail();
        }
    }
}