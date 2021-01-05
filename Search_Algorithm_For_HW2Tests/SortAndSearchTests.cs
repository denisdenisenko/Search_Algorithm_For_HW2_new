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
                // arrange

            int[] notSortedArray = { 5, 4, 3, 2, 1 };
            int[] sortedArray = { 1, 2, 3, 4, 5 };
            int[] notSortableArray = { 3, 3, 3, 3, 3, 3, 3 };
                //act

            SortAndSearch.SortAlgorithm(ref notSortedArray);
                //assert

            Assert.IsTrue(sortedArray.SequenceEqual(notSortedArray));
            Assert.IsFalse(notSortableArray.SequenceEqual(sortedArray));
        }

        [TestMethod()]
        public void FirstSearchTest()
        {
                //arrange

            int[] exampleArray = { 6, 9, 52, -20, 100 };
            int firstValueToFind = 0;
            int secondValueToFind = -20;
            int thirdValueToFind = 100;
                //act

            int returnedIndex1 = SortAndSearch.FirstSearch(exampleArray, firstValueToFind);
            int returnedIndex2 = SortAndSearch.FirstSearch(exampleArray, secondValueToFind);
            int returnedIndex3 = SortAndSearch.FirstSearch(exampleArray, thirdValueToFind);
                //assert

            Assert.AreEqual(returnedIndex1, -1);
            Assert.AreEqual(returnedIndex2, 0);
            Assert.AreEqual(returnedIndex3, 4);
        }

        [TestMethod()]
        public void helpingSearchTest()
        {
                //arrange
            int[] exampleArray = { 1, 2, 3, 4, 5 };
            int searchValue1 = 2;
            int searchValue2 = 0;
            int left = 0;
            int right = exampleArray.Length;
                //act

            int returnedIndex = SortAndSearch.helpingSearch(exampleArray, searchValue1, left, right);
            int returnedIndex2 = SortAndSearch.helpingSearch(exampleArray, searchValue2, left, right);
                //assert

            Assert.AreEqual(returnedIndex, 1);
            Assert.AreEqual(returnedIndex2, -1);
        }

        [TestMethod()]
        public void SecondSearchTest()
        {
                //arrange
            int[] exampleArray = { 6, 9, 52, -20, 100 };
            int firstValueToFind = 0;
            int secondValueToFind = 100;
            int thirdValueToFind = -20;
                //act
            
            int returnedIndex = SortAndSearch.SecondSearch(exampleArray, firstValueToFind);
            int returnedIndex2 = SortAndSearch.SecondSearch(exampleArray, secondValueToFind);
            int returnedIndex3 = SortAndSearch.SecondSearch(exampleArray, thirdValueToFind);
                //assert

            Assert.AreEqual(returnedIndex, -1);
            Assert.AreEqual(returnedIndex2, 4);   
            Assert.AreEqual(returnedIndex3, -1, "Index algorithm = " + returnedIndex3);

        }

        [TestMethod()]
        public void ThirdSearchTest()
        {
            //arrange
            int[] exampleArray = { 9,8,55,3,-13,56,101,2,0,1000};
            int firstValueToFind = 0;
            int secondValueToFind = 1000;
            int thirdValueToFind = 88;       // not exists
            //act

            int returnedIndex = SortAndSearch.ThirdSearch(exampleArray, firstValueToFind);
            int returnedIndex2 = SortAndSearch.ThirdSearch(exampleArray, secondValueToFind);
            int returnedIndex3 = SortAndSearch.ThirdSearch(exampleArray, thirdValueToFind);
            //assert

            Assert.AreEqual(returnedIndex, 1);
            Assert.AreEqual(returnedIndex2, 9);
            Assert.AreEqual(returnedIndex3, -1);
        }

        [TestMethod()]
        public void DisplayElementsTest()
        {
            Assert.Fail();
        }
    }
}