using System;
using System.Collections.Generic;
using System.Linq;

namespace Qoden2
{
    public class Word
    {
        private readonly HashSet<string> hash = new HashSet<string>();
        public readonly List<int> ListOfPoint = new List<int>();
        private int counter = 0;
        public int MaxLengthOfArr;
        public readonly List<string> MainStrOne = new List<string>();
        public bool Trofl { get; set; } = false;
        public bool Temptofl { get; set; } = true;
        public void OutLine(List<string> mainStrOne)
        {
            foreach (var t in mainStrOne)
            {
                Console.WriteLine(t);
            }
        }
        public void HashAdd(string[] arrText)
        {
            foreach (var t in arrText)
            {
                hash.Add(t);
            }
            MaxLengthOfArr = hash.Select(hashItem => hashItem.Length).Concat(new[] {0}).Max();
        }
        public void ListAdd(string[] arrText)
        {
            foreach (string hashItem in hash)
            {
                int repeatElement = 0;
                foreach (var t in arrText)
                {
                    if (t == hashItem)
                    {
                        repeatElement++;
                    }
                }
                ListOfPoint.Add(repeatElement);
            }
        }
        public void FormConstructor(int maxPoint)
        {
            foreach (string hashItem in hash)
            {
                string under = Underscores(MaxLengthOfArr, hashItem);
                string pointers = MainPointer(ListOfPoint[counter], maxPoint);
                counter++;
                string str = under + hashItem + " " + pointers;
                MainStrOne.Add(str);
            }
        }
        public bool IsNiceSort(List<string> str, List<int> listOfPoint, bool trofl)
        {
            for (int i = 1; i < str.Count ; i++)
            {
                
                if (listOfPoint[i] < listOfPoint[i-1] )
                {
                    listOfPoint = SwapPoint(listOfPoint[i], listOfPoint[i - 1], listOfPoint, i);
                    str = SwapElement(str, i);
                    trofl = true;
                    return trofl;
                }
                else
                {
                    trofl = false;
                }
            }
            return trofl;
        }

        private List<string> SwapElement(List<string> oldStr, int i)
        {
            List<string> newStr = oldStr;
            string temp = newStr[i - 1];
            newStr[i - 1] = newStr[i];
            newStr[i] = temp;
            return newStr;
        }

        private List<int> SwapPoint(int a, int b, List<int> oldList, int i)
        {
            List<int> newList = oldList;
            newList[i] = b;
            newList[i - 1] = a;
            return newList;
        }

        private string MainPointer(int countOfPoint, int maxPoint)
        {
            double temp = 0;
            string pointSum = "";
            double countPoints = Points(countOfPoint, maxPoint);
            while(countPoints > temp)
            {
                pointSum = pointSum + ".";
                temp++;
            }
            return pointSum;
        }
        public int MaxPointsInListOfPoints(List<int> listOfPoint)
        {
            int maxPoint = 0;
            foreach (int t in listOfPoint)
            {
                if (maxPoint < t)
                {
                    maxPoint = t;
                }
            }
            return maxPoint;
        }

        private double Points(int countOfPoints, int maxPoint)
        {
            double newPoints = (double)countOfPoints / (double)maxPoint;   
            if (countOfPoints % maxPoint == 0)
            {
                return 10;
            }
            else
            {
                if (newPoints >= 0.55)
                {
                    newPoints = ((newPoints * 10) - newPoints) + 1;
                    return newPoints;
                }
                else
                {
                    newPoints = (newPoints * 10) - newPoints;
                    if (newPoints >= 1)
                    {
                        newPoints = Math.Ceiling(newPoints);
                        return newPoints;
                    }
                    else
                    {
                        double truncate = Math.Truncate(newPoints);
                        return truncate;
                    }
                }
            }
        }
        private string Underscores(int maxLengthOfArr, string hashItem)
        {
            int maxNow = hashItem.Length;
            string underSum = "";
            while (maxLengthOfArr > maxNow)
            {
                underSum = underSum + "_";
                maxNow++;
            }
            return underSum;
        }
    }
}