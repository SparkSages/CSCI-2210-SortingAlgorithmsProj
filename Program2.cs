#region  FileHeader
///////////////////////////////////////////////////////////////////////////////
//
// Authors: Brendan Dalhover - dalhover@etsu.edu
//          Deep Desai - desaid@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 2 - Sorting Algorithms
// Description: Literally did this just to run our program on one line
//
///////////////////////////////////////////////////////////////////////////////
#endregion
abstract class Program2
{
    public static void RunSorts()
    {
        IntegerSort.SortUsingIntegers();
        BookSort.SortUsingBooks();
    }
}