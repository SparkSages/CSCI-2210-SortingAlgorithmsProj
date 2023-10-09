#region  FileHeader
///////////////////////////////////////////////////////////////////////////////
//
// Authors: Brendan Dalhover - dalhover@etsu.edu
//          Deep Desai - desaid@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 2 - Sorting Algorithms
// Description: Merge Sort Implementation
//
///////////////////////////////////////////////////////////////////////////////
#endregion
using System.Data;
using System.Collections.Generic;
namespace SortingAlgorithms.BubbleSort
{
    /// <summary>
    /// Merge Sort Implementation
    /// </summary>
    /// <typeparam name="T"></typeparam>

    public class MergeSort<T> : ISort<T> where T : IComparable<T>
    {
        /// <summary>
        /// Sorts the specified values.
        /// </summary>
        /// <param name="values">The values</param>
        public void Sort(List<T> values)
        {
            //If the list is empty or has one element, it is sorted
            if (values == null || values.Count <= 1)
                return;

            List<T> sortedList = MergeSortInternal(values);
            values.Clear();
            values.AddRange(sortedList);
        }

        /// <summary>
        /// Merges the sort internal.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns>List<T></returns>
        private List<T> MergeSortInternal(List<T> values)
        {
            //Base case
            //if the list is empty or has one element, it is sorted
            if (values.Count <= 1)
                return values;

            //Recursive case
            //split the list into two halves
            int middle = values.Count / 2;
            List<T> left = new List<T>(values.GetRange(0, middle));
            List<T> right = new List<T>(values.GetRange(middle, values.Count - middle));

            left = MergeSortInternal(left);
            right = MergeSortInternal(right);

            return Merge(left, right);
        }

        /// <summary>
        /// Merges the specified left and right.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>List<T></returns>
        private List<T> Merge(List<T> left, List<T> right)
        {
            //create a new list to hold the sorted elements
            List<T> result = new List<T>();
            int leftIndex = 0;
            int rightIndex = 0;

            //While there are elements in both lists
            //compare the elements at the current index
            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (left[leftIndex].CompareTo(right[rightIndex]) <= 0)
                {
                    result.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    result.Add(right[rightIndex]);
                    rightIndex++;
                }
            }

            //Add any remaining elements from the left list
            while (leftIndex < left.Count)
            {
                result.Add(left[leftIndex]);
                leftIndex++;
            }

            //Add any remaining elements from the right list
            while (rightIndex < right.Count)
            {
                result.Add(right[rightIndex]);
                rightIndex++;
            }

            return result;
        }

    }
}

