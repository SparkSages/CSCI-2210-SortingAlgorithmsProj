using SortingAlgorithms;
using LoadTestData;
using SortingAlgorithms.BubbleSort;
using System.Diagnostics;
using System.Text;
using System.Security.AccessControl;

public abstract class IntegerSort
{
    public static void SortUsingIntegers()
    {
        string[] intFilePaths = TestDataLoader.GetIntDataFiles();
        List<List<int>> intList = new();
        foreach (string s in intFilePaths)
        {
            intList.Add(TestDataLoader.LoadIntegerTestData(s));
        }

        foreach (List<int> list in intList)
        {
            List<int> unsortedList = list;
            int accumulatedTime = 0;
            Stopwatch stopwatch = new();
            for (int i = 0; i < 5; i++)
            {
                BubbleSort<int> bubbleSort = new();

                stopwatch.Start();

                bubbleSort.Sort(unsortedList);

                stopwatch.Stop();

                accumulatedTime += (int)stopwatch.ElapsedMilliseconds;
                Console.WriteLine("Bubble Sort");
                Console.WriteLine("-----------");

                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.Out.WriteLine($"Time elapsed: {stopwatch.ElapsedMilliseconds}ms");
                System.Console.WriteLine($"Accumulated Time: {accumulatedTime}ms");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine($"Average Time: {accumulatedTime / 5}ms\n\n");
            unsortedList = list;
            Console.ResetColor();
            Thread.Sleep(1000);
        }
    }



}