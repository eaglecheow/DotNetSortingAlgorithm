using System;
using System.Collections.Generic;

namespace Tools
{
    class SortTools
    {
        public static bool CheckSort (List<double> inputList)
        {
            for (var i = 0; i < inputList.Count - 1; i++)
            {
                if (inputList[i] > inputList[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }

    class ArrayTools
    {
        public static List<double> GenerateArray(int length, int maxNumber)
        {
            Random random = new Random();
            List<double> doubleList = new List<double>();
            for (int i = 0; i < length; i++)
            {
                doubleList.Add(Math.Floor(random.NextDouble() * maxNumber));
            }

            return doubleList;
        }
    }
}