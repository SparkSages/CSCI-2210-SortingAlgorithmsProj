#region  FileHeader
///////////////////////////////////////////////////////////////////////////////
//
// Authors: Brendan Dalhover - dalhover@etsu.edu
//          Deep Desai - desaid@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 2 - Sorting Algorithms
// Description: Loading Test Data from file
//
///////////////////////////////////////////////////////////////////////////////
#endregion
using System.Diagnostics.Contracts;
using System.Globalization;
using Books;

namespace LoadTestData
{
    public class TestDataLoader
    {

        /// <summary>
        /// Loads the integer test data.
        /// </summary>
        /// <returns>a list of Integers to be sorted</returns>
        public static List<int> LoadIntegerTestData(string filePath)
        {
            // Load test data here
            List<int> testData = new List<int>();
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (int.TryParse(line, out int number))
                    {
                        // Successfully parsed an integer, add it to the list
                        testData.Add(number);
                    }

                    else
                    {
                        Console.WriteLine($"Skipping non-integer line: {line}");
                    }
                }
            }
            #region catches
            catch (InvalidCastException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            catch (FileNotFoundException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            catch (ArgumentNullException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            #endregion
            return testData;
        }


        /// <summary>
        /// Loads the book test data.
        /// </summary>
        /// <returns>a list of books to be sorted</returns>
        public static List<Book> LoadBookTestData(string filePath)
        {
            List<Book> testData = new();
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (Book.TryParse(line, out Book? book))
                    {
                        // Successfully parsed a book, add it to the list
                        if (book != null)
                        {
                            testData.Add(book);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Skipping non-book line: {line}");
                    }
                }
            }
            #region catches
            catch (InvalidCastException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            catch (FileNotFoundException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            catch (ArgumentNullException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            #endregion
            return testData;
        }
        /// <summary>
        /// Gets the file paths of the integer test data files
        /// </summary>
        /// <returns>an array of file paths</returns>
        public static string[] GetIntDataFiles()
        {
            string intDataPaths = @".\TestData\IntegerData\";
            string[] files = Directory.GetFiles(intDataPaths);
            foreach (string file in files)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("File Found: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(file + "\n");
                Console.ResetColor();
            }
            return files;
        }

        /// <summary>
        /// Gets the file paths of the book test data files
        /// </summary>
        /// <returns>an array of file paths</returns>
        public static string[] GetBookDataFiles()
        {
            string bookDataPaths = @".\TestData\BookData\";
            string[] files = Directory.GetFiles(bookDataPaths);


            foreach (string file in files)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("File Found: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(file + "\n");
                Console.ResetColor();
            }
            return files;
        }
    }
}