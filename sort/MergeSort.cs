using System;
using System.Collections.Generic;
using Tools;

namespace MergeSortAlgorithm
{
    class MergeSort
    {
        public static List<double> Sort(List<double> inputList)
        {
            if (inputList.Count <= 1)
            {
                return inputList;
            }

            int middleIndex = inputList.Count / 2;

            List<double> leftList = inputList.GetRange(0, middleIndex);
            List<double> rightList = inputList.GetRange(middleIndex, inputList.Count - middleIndex);

            List<double> leftSortedList = Sort(leftList);
            List<double> rightSortedList = Sort(rightList);

            return MergeList(leftSortedList, rightSortedList);
        } 

        private static List<double> MergeList(List<double> listOne, List<double> listTwo)
        {
            List<double> returnList = new List<double>();

            while (listOne.Count > 0 && listTwo.Count > 0)
            {
                double listOneNumber = listOne[0];
                double listTwoNumber = listTwo[0];

                if (listOneNumber < listTwoNumber)
                {
                    returnList.Add(listOneNumber);
                    listOne.Remove(listOneNumber);
                }
                else
                {
                    returnList.Add(listTwoNumber);
                    listTwo.Remove(listTwoNumber);
                }
            }

            if (listOne.Count > 0)
            {
                returnList.AddRange(listOne);
            }

            if (listTwo.Count > 0)
            {
                returnList.AddRange(listTwo);
            }

            return returnList;
        }
    }
}