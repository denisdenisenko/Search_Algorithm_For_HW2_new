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
        public void SortAlgorithmTest_goodExample()
        {
                // arrange

            int[] notSortedArray = { 5, 4, 3, 2, 1 };
            int[] sortedArray = { 1, 2, 3, 4, 5 };
            int[] notSortableArray = { 3, 3, 3, 3, 3, 3, 3 };
                //act

            SortAndSearch.SortAlgorithm(ref notSortedArray);
                //assert

            Assert.IsTrue(sortedArray.SequenceEqual(notSortedArray));
        }
        [TestMethod()]
        public void SortAlgorithmTest_badExample()
        {
            // arrange

            int[] notSortedArray = { 5, 4, 3, 2, 1 };
            int[] sortedArray = { 1, 2, 3, 4, 5 };
            int[] notSortableArray = { 3, 3, 3, 3, 3, 3, 3 };
            //act

            SortAndSearch.SortAlgorithm(ref notSortedArray);
            //assert

            Assert.IsFalse(notSortableArray.SequenceEqual(sortedArray));
        }

        [TestMethod()]
        public void FirstSearch_Test_whenValueNotExists()
        {
                //arrange

            int[] exampleArray = { 6, 9, 52, -20, 100 };
            int firstValueToFind = 0;

                //act

            int returnedIndex1 = SortAndSearch.FirstSearch(exampleArray, firstValueToFind);

                //assert

            Assert.AreEqual(returnedIndex1, -1);

        }

        [TestMethod()]
        public void FirstSearch_Test_whenValueExist()
        {
            //arrange

            int[] exampleArray = { 6, 9, 52, -20, 100 };
            int secondValueToFind = -20;

            //act

            int returnedIndex2 = SortAndSearch.FirstSearch(exampleArray, secondValueToFind);

            //assert

            Assert.AreEqual(returnedIndex2, 0);

        }

        [TestMethod()]
        public void FirstSearch_Test_valueExists_another_boundary()
        {
            //arrange

            int[] exampleArray = { 6, 9, 52, -20, 100 };

            int thirdValueToFind = 100;
            //act

            int returnedIndex3 = SortAndSearch.FirstSearch(exampleArray, thirdValueToFind);
            //assert


            Assert.AreEqual(returnedIndex3, 4);
        }


        [TestMethod()]
        public void helpingSearch_Test_valueExists()
        {
                //arrange
            int[] exampleArray = { 1, 2, 3, 4, 5 };
            int searchValue1 = 2;

            int left = 0;
            int right = exampleArray.Length;
                //act

            int returnedIndex = SortAndSearch.helpingSearch(exampleArray, searchValue1, left, right);

                //assert

            Assert.AreEqual(returnedIndex, 1);

        }

        [TestMethod()]
        public void helpingSearch_Test_valueNotExists()
        {
            //arrange
            int[] exampleArray = { 1, 2, 3, 4, 5 };

            int searchValue2 = 0;
            int left = 0;
            int right = exampleArray.Length;
            //act

            int returnedIndex2 = SortAndSearch.helpingSearch(exampleArray, searchValue2, left, right);
            //assert

            Assert.AreEqual(returnedIndex2, -1);
        }

        [TestMethod()]
        public void SecondSearch_Test_valueNotExists()
        {
                //arrange
            int[] exampleArray = { 6, 9, 52, -20, 100 };
            int firstValueToFind = 0;

                //act
            
            int returnedIndex = SortAndSearch.SecondSearch(exampleArray, firstValueToFind);

                //assert

            Assert.AreEqual(returnedIndex, -1);


        }

        [TestMethod()]
        public void SecondSearch_Test_valueExists()
        {
            //arrange
            int[] exampleArray = { 6, 9, 52, -20, 100 };
            int secondValueToFind = 100;
            //act

            int returnedIndex2 = SortAndSearch.SecondSearch(exampleArray, secondValueToFind);
            //assert

            Assert.AreEqual(returnedIndex2, 4);

        }

        [TestMethod()]
        public void SecondSearch_Test_valueExists_and_its_first_index()
        {
            //arrange
            int[] exampleArray = { 6, 9, 52, -20, 100 };

            int thirdValueToFind = -20;
            //act

            int returnedIndex3 = SortAndSearch.SecondSearch(exampleArray, thirdValueToFind);
            //assert

            Assert.AreEqual(returnedIndex3, -1, "Index algorithm = " + returnedIndex3);

        }



        [TestMethod()]
        public void ThirdSearch_Test_vaueExists()
        {
            //arrange
            int[] exampleArray = { 9,8,55,3,-13,56,101,2,0,1000};
            int firstValueToFind = 0;

            //act

            int returnedIndex = SortAndSearch.ThirdSearch(exampleArray, firstValueToFind);

            //assert

            Assert.AreEqual(returnedIndex, 1);

        }

        [TestMethod()]
        public void ThirdSearch_Test_valueExists_another_boundary()
        {
            //arrange
            int[] exampleArray = { 9, 8, 55, 3, -13, 56, 101, 2, 0, 1000 };
            int secondValueToFind = 1000;
            //act

            int returnedIndex2 = SortAndSearch.ThirdSearch(exampleArray, secondValueToFind);
            //assert

            Assert.AreEqual(returnedIndex2, 9);
        }

        [TestMethod()]
        public void ThirdSearch_Test_valueNotExists()
        {
            //arrange
            int[] exampleArray = { 9, 8, 55, 3, -13, 56, 101, 2, 0, 1000 };

            int thirdValueToFind = 88;       // not exists
            //act


            int returnedIndex3 = SortAndSearch.ThirdSearch(exampleArray, thirdValueToFind);
            //assert

            Assert.AreEqual(returnedIndex3, -1);
        }

        [TestMethod()]

        public void private_class_searchingAlgorithms_LinearSearch_value_Exists() 
        {
            // arrange

            int[] exampleArray = { 9, 8, 55, 3, -13, 56, 101, 2, 0, 1000 };
            int searchValue = 55;
            String searchType = "LinearSearch";
            PrivateType privateTypeObject = new PrivateType(typeof(SortAndSearch));

            //act
            string actualValue = (string)privateTypeObject.InvokeStatic("searchingAlgorithms", exampleArray, searchValue, searchType);
            string expected = "Using LinearSearch ALGORITHM to look for value= 55 Found it at location= 6";
            //assert

            Assert.AreEqual(actualValue, expected);
        }

        [TestMethod()]

        public void private_class_searchingAlgorithms_LinearSearch_value_Not_Exists()
        {
            // arrange

            int[] exampleArray = { 9, 8, 55, 3, -13, 56, 101, 2, 0, 1000 };
            int searchValue = 11;
            String searchType = "LinearSearch";
            PrivateType privateTypeObject = new PrivateType(typeof(SortAndSearch));

            //act
            string actualValue = (string)privateTypeObject.InvokeStatic("searchingAlgorithms", exampleArray, searchValue, searchType);
            string expected = "Using LinearSearch ALGORITHM: Value was not found in list";
            //assert

            Assert.AreEqual(actualValue, expected);
        }


        [TestMethod()]

        public void private_class_searchingAlgorithms_BinarySearch_value_Exists()
        {
            // arrange

            int[] exampleArray = { 9, 8, 55, 3, -13, 56, 101, 2, 0, 1000 };
            int searchValue = 55;
            String searchType = "BinarySearch";
            PrivateType privateTypeObject = new PrivateType(typeof(SortAndSearch));

            //act
            string actualValue = (string)privateTypeObject.InvokeStatic("searchingAlgorithms", exampleArray, searchValue, searchType);
            string expected = "Using BinarySearch ALGORITHM to look for value= 55 Found it at location= 6";
            //assert

            Assert.AreEqual(actualValue, expected);
        }

        [TestMethod()]

        public void private_class_searchingAlgorithms_BinarySearch_value_Not_Exists()
        {
            // arrange

            int[] exampleArray = { 9, 8, 55, 3, -13, 56, 101, 2, 0, 1000 };
            int searchValue = 11;
            String searchType = "BinarySearch";
            PrivateType privateTypeObject = new PrivateType(typeof(SortAndSearch));

            //act
            string actualValue = (string)privateTypeObject.InvokeStatic("searchingAlgorithms", exampleArray, searchValue, searchType);
            string expected = "Using BinarySearch ALGORITHM: Value was not found in list";
            //assert

            Assert.AreEqual(actualValue, expected);
        }

        [TestMethod()]
        public void DisplayElements_Test()
        {
            Assert.Fail();
        }
    }
}