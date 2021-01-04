using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Algorithm_For_HW2
{
    public class SortAndSearch
    {
        #region Sort Algorithm
        public static void SortAlgorithm(ref int[] x)
        {
            for (int k = x.Length - 1; k > 0; k--)
            {
                bool swapped = false;
                for (int i = k; i > 0; i--)
                    if (x[i] < x[i - 1])
                    {
                        // swap
                        int temp = x[i];
                        x[i] = x[i - 1];
                        x[i - 1] = temp;
                        swapped = true;
                    }
                for (int i = 0; i < k; i++)
                    if (x[i] > x[i + 1])
                    {
                        // swap
                        int temp = x[i];
                        x[i] = x[i + 1];
                        x[i + 1] = temp;
                        swapped = true;
                    }
                if (!swapped)
                    break;
            }
        }
        #endregion

        #region Binary Search
        public static int FirstSearch(int[] x, int searchValue)
        {
            // Returns index of searchValue in sorted array x, or -1 if not found
            SortAlgorithm(ref x);
            int left = 0;
            int right = x.Length;
            return helpingSearch(x, searchValue, left, right);
        }
        public static int helpingSearch(int[] x, int searchValue, int left, int right)
        {
            if (right < left)
            {
                return -1;
            }
            int mid = (left + right) >> 1;
            if (searchValue > x[mid])
            {
                return helpingSearch(x, searchValue, mid + 1, right);
            }
            else if (searchValue < x[mid])
            {
                return helpingSearch(x, searchValue, left, mid - 1);
            }
            else
            {
                return mid + 1;
            }
        }
        #endregion

        #region Interpolation Search
        public static int SecondSearch(int[] x, int searchValue)
        {
            // Returns index of searchValue in sorted input data
            // array x, or -1 if searchValue is not found
            SortAlgorithm(ref x);
            int low = 0;
            int high = x.Length - 1;
            int mid;

            while (x[low] < searchValue && x[high] >= searchValue)
            {
                mid = low + ((searchValue - x[low]) * (high - low)) / (x[high] - x[low]);

                if (x[mid] < searchValue)
                    low = mid + 1;
                else if (x[mid] > searchValue)
                    high = mid - 1;
                else
                    return mid - 1;
            }

            if (x[low] == searchValue)
            {
                Console.WriteLine("Index algorithm = " + low);
                return low - 1;
            }
            return -1;
        }
        #endregion

        public static int ThirdSearch(int[] x, int searchValue)
        {
            SortAlgorithm(ref x);
            int n = x.Length;
            for (int i = 0; i < n; i++)
            {
                if (x[i] == searchValue)
                    return i;
            }
            return -1;
        }

        private static string searchingAlgorithms(ref int[] x, int searchValue, string serachType)
        {
            var returnValue = "";
            var result = -1;
            switch (serachType)
            {
                case "LinearSearch":
                    returnValue = ReturnValue(ref x, searchValue, ThirdSearch, serachType);
                    break;
                case "BinarySearch":
                    returnValue = ReturnValue(ref x, searchValue, FirstSearch, serachType);
                    break;
                case "InterpolationSearch":
                    returnValue = ReturnValue(ref x, searchValue, SecondSearch, serachType);
                    break;
                default:
                    throw new System.InvalidOperationException("No such algorithm: " + serachType);
            }
            return returnValue;
        }

        #region Tools
        private static string ReturnValue(ref int[] x, int searchValue, Func<int[], int, int> myMethodName, string searchType)
        {
            string returnValue;

            int result = myMethodName(x, searchValue);
            if (result == -1)
                returnValue = "Using " + searchType + " ALGORITHM: Value was not found in list";
            else
                returnValue = "Using " + searchType + " ALGORITHM to look for value= " + searchValue +
                              " Found it at location= " + result;
            return returnValue;
        }

        static void MixDataUp(ref int[] x, Random rdn)
        {
            for (int i = 0; i <= x.Length - 1; i++)
            {
                x[i] = (int)(rdn.NextDouble() * x.Length);
            }
        }

        public static void DisplayElements(ref int[] xArray, char status, string sortname)
        {
            if (status == 'a')
                Console.WriteLine("After sorting using algorithm: " + sortname);
            else
                Console.WriteLine("Before sorting");
            for (int i = 0; i <= xArray.Length - 1; i++)
            {
                if ((i != 0) && (i % 10 == 0))
                    Console.Write("\n");
                Console.Write(xArray[i] + " ");
            }
            Console.ReadLine();
        }
        #endregion
    }
}

