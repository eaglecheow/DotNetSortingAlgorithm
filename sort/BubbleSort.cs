using System;
using System.Collections.Generic;
using Tools;

namespace BubbleSortAlgorithm
{
    class BubbleSort
    {
        public static List<double> Sort(List<double> inputList)
        {
            List<double> sortingList = new List<double>(inputList);
            while (!SortTools.CheckSort(sortingList))
            {
                for (var i = 0; i < sortingList.Count - 1; i++)
                {
                    if (sortingList[i] > sortingList[i + 1])
                    {
                        var temperory = sortingList[i];
                        sortingList[i] = sortingList[i + 1];
                        sortingList[i + 1] = temperory;
                    }
                }
            }

            return sortingList;
        }
    }
}