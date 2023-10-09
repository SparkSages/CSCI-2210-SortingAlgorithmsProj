///////////////////////////////////////////////////////////////////////////////
//
// Authors: Brendan Dalhover - dalhover@etsu.edu
//          Deep Desai - desaid@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 2 - Sorting Algorithms
// Description: Literally did this just to run our program on one line
//
///////////////////////////////////////////////////////////////////////////////
/// <summary>
/// actual program class, this would be our actual program class but we wanted to run it on one line.
/// </summary>
abstract class Program2
{
    public static void RunSorts()
    {
        IntegerSort.SortUsingIntegers();
        BookSort.SortUsingBooks();
    }
}