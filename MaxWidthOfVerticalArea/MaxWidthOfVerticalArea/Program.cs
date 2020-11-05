using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxWidthOfVerticalArea
{
    class Program
    {
        public static int MaxWidthOfVerticalArea(int[,] points)
        {

            List<int> xes = new List<int>();
            for (int i = 0; i < points.GetUpperBound(0) + 1; i++)
            {
                xes.Add(points[i, 0]);
            }
            xes.Sort();

            int max = int.MinValue;
            for (int i = 1; i < xes.Count; i++)
                if (xes[i] - xes[i - 1] > max)
                    max = xes[i] - xes[i - 1];
            return max;
        }
        static void Main(string[] args)
        {
            var xx = new int[,] { { 8, 7 }, { 9, 9 }, { 7, 4 }, { 9, 7 } };
            Console.WriteLine(MaxWidthOfVerticalArea(xx));
        }
    }
}
