#region  FileHeader
///////////////////////////////////////////////////////////////////////////////
//
// Authors: Brendan Dalhover - dalhover@etsu.edu
//          Deep Desai - desaid@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 2 - Sorting Algorithms
// Description: Bubble Sort Implementation
//
///////////////////////////////////////////////////////////////////////////////
#endregion
using System.Data;
using System.Collections.Generic;
namespace SortingAlgorithms.BubbleSort
{
    /// <summary>
    /// Bubble Sort Class
    /// </summary>
    public class BubbleSort<T> : ISort<T> where T : IComparable<T>
    {

        /// <summary>
        /// Sorts the specified values.
        /// </summary>
        /// <param name="values">The values.</param>
        public void Sort(List<T> values)
        {
            ///////////////////////////////////
            /// Bubble Sort
            ///////////////////////////////////
            T tempValue;
            for (int i = 0; i < values.Count(); i++)
            {
                for (int j = 0; j < values.Count() - 1; j++)
                {
                    if (values[j].CompareTo(values[j + 1]) > 0)
                    {
                        tempValue = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = tempValue;
                    }
                }
            }
        }
    }
}
