using SortingAlgorithms;
using LoadTestData;
using SortingAlgorithms.BubbleSort;
using System.Diagnostics;
using System.Text;
using System.Security.AccessControl;
using System.IO;
using Books;

public abstract class BookSort
{
    public static void SortUsingBooks()
    {
        string filePath = "BookSortingCSV.csv";
        StreamWriter csvWriter = new StreamWriter(filePath);
        csvWriter.WriteLine("Algorithm, Data File, Time Elapsed (ms)");
        string[] bookFilePaths = TestDataLoader.GetBookDataFiles();
        List<List<Book>> bookList = new();

        //int listIndex = 0;
        foreach (string s in bookFilePaths)
        {
            bookList.Add(TestDataLoader.LoadBookTestData(s));
        }
        int filePathIndex = 0;

        /// <summary>
        /// Bubble Sort
        /// </summary>
        foreach (List<Book> list in bookList)
        {
            List<Book> unsortedList = list;
            int accumulatedTime = 0;

            for (int i = 0; i < 5; i++)
            {
                Stopwatch stopwatch = new();
                BubbleSort<Book> bubbleSort = new();


                //removes startup overhead due to initialization of bubble sort
                // bubbleSort.Sort(sortedList);

                stopwatch.Start();

                bubbleSort.Sort(unsortedList);

                stopwatch.Stop();

                accumulatedTime += (int)stopwatch.ElapsedMilliseconds;
                Console.WriteLine($"Bubble Sort {i}");
                Console.WriteLine("-----------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.Out.WriteLine($"Time elapsed: {stopwatch.ElapsedMilliseconds}ms");
                System.Console.WriteLine($"Accumulated Time: {accumulatedTime}ms");
                Console.ResetColor();
            }
            csvWriter.WriteLineAsync($"Bubble Sort, {bookFilePaths[filePathIndex]}, {accumulatedTime / 5}");
            filePathIndex++;
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine($"Average Time: {accumulatedTime / 5}ms\n\n");
            Console.ResetColor();
        }

        filePathIndex = 0;
        /// <summary>
        /// Merge Sort
        /// </summary>
        foreach (List<Book> list in bookList)
        {
            List<Book> unsortedList = list;
            int accumulatedTime = 0;

            for (int i = 0; i < 5; i++)
            {
                Stopwatch stopwatch = new();
                MergeSort<Book> mergeSort = new();


                //removes startup overhead due to initialization of bubble sort
                //List<int> sortedList = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                //mergeSort.Sort(sortedList);

                stopwatch.Start();

                mergeSort.Sort(unsortedList);

                stopwatch.Stop();

                accumulatedTime += (int)stopwatch.ElapsedMilliseconds;
                Console.WriteLine($"Merge Sort {i}");
                Console.WriteLine("-----------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.Out.WriteLine($"Time elapsed: {stopwatch.ElapsedMilliseconds}ms");
                System.Console.WriteLine($"Accumulated Time: {accumulatedTime}ms");
                Console.ResetColor();
            }
            csvWriter.WriteLine($"Merge Sort, {bookFilePaths[filePathIndex]}, {accumulatedTime / 5}");
            filePathIndex++;
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine($"Average Time: {accumulatedTime / 5}ms\n\n");
            Console.ResetColor();
        }
        csvWriter.Close();
    }

}