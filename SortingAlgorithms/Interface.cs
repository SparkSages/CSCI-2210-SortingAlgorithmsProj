///////////////////////////////////////////////////////////////////////////////
//
// Authors: Brendan Dalhover - dalhover@etsu.edu
//          Deep Desai - desaid@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 2 - Sorting Algorithms
// Description: Implementing ISort Interface
//
///////////////////////////////////////////////////////////////////////////////
using System;
/// <summary>
/// Interface for sorting algorithms
/// </summary>
public interface ISort<T> where T : IComparable<T>
{
    void Sort(List<T> values);
}

