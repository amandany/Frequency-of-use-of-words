using System;
using System.Collections.Generic;
using System.Linq;

namespace Qoden2
{
    class Program
    {
        static void Main(string[] args)
        {
            Word word = new Word();
            string text = Console.ReadLine();
            string[] arrText = text.Split(' ');
            word.HashAdd(arrText);
            word.ListAdd(arrText);
            int maxPoint = word.MaxPointsInListOfPoints(word.ListOfPoint);
            word.FormConstructor(maxPoint);
            while (word.Temptofl)
            {
                word.Temptofl = word.IsNiceSort(word.MainStrOne, word.ListOfPoint, word.Trofl);
            }
            word.OutLine(word.MainStrOne);
        }
    }
}