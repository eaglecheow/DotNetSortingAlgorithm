using System;
using System.Collections.Generic;
using System.Diagnostics;
using BubbleSortAlgorithm;
using MergeSortAlgorithm;
using Tools;

namespace DotNetSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            List<double> randomList = ArrayTools.GenerateArray(1000000, 1000);

            System.Console.WriteLine("Array Generated");
            System.Console.WriteLine("Starting to sort array...");

            stopwatch.Start();
            List<double> sortedList = MergeSort.Sort(randomList);
            stopwatch.Stop();

            Console.WriteLine($"Sorting took {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
