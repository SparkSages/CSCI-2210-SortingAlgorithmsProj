#region FileHeader
///////////////////////////////////////////////////////////////////////////////
//
// Authors: Brendan Dalhover - dalhover@etsu.edu
//          Deep Desai - desaid@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 2 - Sorting Algorithms
// Description: Implementing ISort Interface
//
///////////////////////////////////////////////////////////////////////////////
#endregion

using System;

public interface ISort<T> where T : IComparable<T>
{
    void Sort(List<T> values);
}

