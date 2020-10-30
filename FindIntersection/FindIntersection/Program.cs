using System;
using System.Linq;

namespace FindIntersection
{
    //    Have the function FindIntersection(strArr) read the array of strings stored in strArr which will contain 2 elements: the first element will represent a list of comma-separated numbers sorted in ascending order, the second element will represent a second list of comma-separated numbers(also sorted). Your goal is to return a comma-separated string containing the numbers that occur in elements of strArr in sorted order.If there is no intersection, return the string false.
    //Examples
    //Input: new string[] {"1, 3, 4, 7, 13", "1, 2, 4, 13, 15"}
    //Output: 1,4,13
    //Input: new string[] { "1, 3, 9, 10, 17, 18", "1, 4, 9, 10" }
    //Output: 1,9,10

    class Program
    {
        public static string FindIntersection(string[] strArr)
        {
            var first = strArr[0].Split(',').ToList().Select(x => x.Trim()).ToList();
            var second = strArr[1].Split(',').ToList().Select(x => x.Trim()).ToList();
            var intersect = first.Intersect(second);
            if (intersect.Count() == 0)
            {
                return "false";
            }
            return String.Join(", ", intersect);


        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(FindIntersection(new string[] { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15" }));
        }
    }
}
