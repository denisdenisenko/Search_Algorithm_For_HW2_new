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
            int ValueToFind = 0;

                //act

            int returnedIndex = SortAndSearch.FirstSearch(exampleArray, ValueToFind);

                //assert

            Assert.AreEqual(returnedIndex, -1);

        }

        [TestMethod()]
        public void FirstSearch_Test_whenValueExist()
        {
            //arrange

            int[] exampleArray = { 6, 9, 52, -20, 100 };
            int ValueToFind = -20;

            //act

            int returnedIndex = SortAndSearch.FirstSearch(exampleArray, ValueToFind);

            //assert

            Assert.AreEqual(returnedIndex, 0);

        }

        [TestMethod()]
        public void FirstSearch_Test_valueExists_another_boundary()
        {
            //arrange

            int[] exampleArray = { 6, 9, 52, -20, 100 };

            int ValueToFind = 100;
            //act

            int returnedIndex = SortAndSearch.FirstSearch(exampleArray, ValueToFind);
            //assert


            Assert.AreEqual(returnedIndex, 4);
        }

        [TestMethod()]
        public void FirstSearch_Test_valueExists_array_of_same_values()
        {
            //arrange

            int[] exampleArray = { 100, 100, 100, 100, 100 };

            int ValueToFind = 100;
            //act

            int returnedIndex = SortAndSearch.FirstSearch(exampleArray, ValueToFind);
            //assert


            Assert.AreEqual(returnedIndex, 2);
        }


        [TestMethod()]
        public void helpingSearch_Test_valueExists()
        {
                //arrange
            int[] exampleArray = { 1, 2, 3, 4, 5 };
            int searchValue = 2;

            int left = 0;
            int right = exampleArray.Length;
                //act

            int returnedIndex = SortAndSearch.helpingSearch(exampleArray, searchValue, left, right);

                //assert

            Assert.AreEqual(returnedIndex, 1);

        }

        [TestMethod()]
        public void helpingSearch_Test_valueNotExists()
        {
            //arrange
            int[] exampleArray = { 1, 2, 3, 4, 5 };

            int searchValue = 0;
            int left = 0;
            int right = exampleArray.Length;
            //act

            int returnedIndex = SortAndSearch.helpingSearch(exampleArray, searchValue, left, right);
            //assert

            Assert.AreEqual(returnedIndex, -1);
        }

        [TestMethod()]
        public void SecondSearch_Test_valueNotExists()
        {
                //arrange
            int[] exampleArray = { 6, 9, 52, -20, 100 };
            int ValueToFind = 0;

                //act
            
            int returnedIndex = SortAndSearch.SecondSearch(exampleArray, ValueToFind);

                //assert

            Assert.AreEqual(returnedIndex, -1);


        }

        [TestMethod()]
        public void SecondSearch_Test_valueExists()
        {
            //arrange
            int[] exampleArray = { 6, 9, 52, -20, 100 };
            int ValueToFind = 100;
            //act

            int returnedIndex = SortAndSearch.SecondSearch(exampleArray, ValueToFind);
            //assert

            Assert.AreEqual(returnedIndex, 4);

        }

        [TestMethod()]
        public void SecondSearch_Test_valueExists_anotheBoundary()
        {
            //arrange
            int[] exampleArray = { 6, 9, 52, -20, 100 };
            int ValueToFind = 52;
            //act

            int returnedIndex = SortAndSearch.SecondSearch(exampleArray, ValueToFind);
            //assert

            Assert.AreEqual(returnedIndex, 3);

        }

        [TestMethod()]
        public void SecondSearch_Test_valueExists_array_with_same_values()
        {
            //arrange
            int[] exampleArray = { 100, 100, 100, 100, 100 };
            int ValueToFind = 100;
            //act

            int returnedIndex = SortAndSearch.SecondSearch(exampleArray, ValueToFind);
            //assert

            Assert.AreEqual(returnedIndex, 0);

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

            Assert.AreEqual(returnedIndex3, 0, "Index algorithm = " + returnedIndex3);

        }



        [TestMethod()]
        public void ThirdSearch_Test_vaueExists()
        {
            //arrange
            int[] exampleArray = { 9,8,55,3,-13,56,101,2,0,1000};
            int ValueToFind = 0;

            //act

            int returnedIndex = SortAndSearch.ThirdSearch(exampleArray, ValueToFind);

            //assert

            Assert.AreEqual(returnedIndex, 1);

        }

        [TestMethod()]
        public void ThirdSearch_Test_valueExists_another_boundary()
        {
            //arrange
            int[] exampleArray = { 9, 8, 55, 3, -13, 56, 101, 2, 0, 1000 };
            int ValueToFind = 1000;
            //act

            int returnedIndex = SortAndSearch.ThirdSearch(exampleArray, ValueToFind);
            //assert

            Assert.AreEqual(returnedIndex, 9);
        }

        [TestMethod()]
        public void ThirdSearch_Test_valueNotExists()
        {
            //arrange
            int[] exampleArray = { 9, 8, 55, 3, -13, 56, 101, 2, 0, 1000 };

            int ValueToFind = 88;       // not exists
            //act


            int returnedIndex = SortAndSearch.ThirdSearch(exampleArray, ValueToFind);
            //assert

            Assert.AreEqual(returnedIndex, -1);
        }

        [TestMethod()]
        public void ThirdSearch_Test_array_with_same_values()
        {
            //arrange
            int[] exampleArray = { 100, 100, 100, 100 ,100, 100, 100, 100, 100 };

            int ValueToFind = 100;       // not exists
            //act


            int returnedIndex = SortAndSearch.ThirdSearch(exampleArray, ValueToFind);
            //assert

            Assert.AreEqual(returnedIndex, 0);
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
        public void private_class_searchingAlgorithms_InterpolationSearch_value_Exists()
        {
            // arrange

            int[] exampleArray = { 9, 8, 55, 3, -13, 56, 101, 2, 0, 1000 };
            int searchValue = 55;
            String searchType = "InterpolationSearch";
            PrivateType privateTypeObject = new PrivateType(typeof(SortAndSearch));

            //act
            string actualValue = (string)privateTypeObject.InvokeStatic("searchingAlgorithms", exampleArray, searchValue, searchType);
            string expected = "Using InterpolationSearch ALGORITHM to look for value= 55 Found it at location= 6";
            //assert

            Assert.AreEqual(actualValue, expected);
        }

        [TestMethod()]

        public void private_class_searchingAlgorithms_InterpolationSearch_value_Not_Exists()
        {
            // arrange

            int[] exampleArray = { 9, 8, 55, 3, -13, 56, 101, 2, 0, 1000 };
            int searchValue = 11;
            String searchType = "InterpolationSearch";
            PrivateType privateTypeObject = new PrivateType(typeof(SortAndSearch));

            //act
            string actualValue = (string)privateTypeObject.InvokeStatic("searchingAlgorithms", exampleArray, searchValue, searchType);
            string expected = "Using InterpolationSearch ALGORITHM: Value was not found in list";
            //assert

            Assert.AreEqual(actualValue, expected);
        }


        [TestMethod()]
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void private_class_searchingAlgorithms_algorithm_not_exists()
        {
            // arrange

            int[] exampleArray = { 9, 8, 55, 3, -13, 56, 101, 2, 0, 1000 };
            int searchValue = 11;
            String searchType = "SomeOtheAlgorithm";
            PrivateType privateTypeObject = new PrivateType(typeof(SortAndSearch));

            //act
            string actualValue = (string)privateTypeObject.InvokeStatic("searchingAlgorithms", exampleArray, searchValue, searchType);
            string expected = "No such algorithm: " + searchType;
            //assert

            Assert.AreEqual(actualValue, expected);
        }

    }
}