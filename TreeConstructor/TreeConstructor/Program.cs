using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeConstructor
{
    //    Tree Constructor
    //Have the function TreeConstructor(strArr) take the array of strings stored in strArr, which will contain pairs of integers in the following format: (i1, i2), where i1 represents a child node in a tree and the second integer i2 signifies that it is the parent of i1.For example: if strArr is ["(1,2)", "(2,4)", "(7,2)"], then this forms the following tree:

    // which you can see forms a proper binary tree.Your program should, in this case, return the string true because a valid binary tree can be formed. If a proper binary tree cannot be formed with the integer pairs, then return the string false. All of the integers within the tree will be unique, which means there can only be one node in the tree with the given integer value.
    // Examples
    // Input: new string[] {"(1,2)", "(2,4)", "(5,7)", "(7,2)", "(9,5)"}
    //Output: true
    //Input: new string[] { "(1,2)", "(3,2)", "(2,12)", "(5,2)" }
    //Output: false
    class Program
    {
        public static string TreeConstructor(string[] strArr)
        {
            var dic = new Dictionary<char, int>();
            foreach (var item in strArr)
            {
                if (dic.ContainsKey(item[3]))
                {
                    dic[item[3]] += 1;
                    if (dic[item[3]] > 2)
                        return "false";
                }
                else
                    dic[item[3]] = 1;
            }
            return "true";

        }

        static void Main(string[] args)
        {
            Console.WriteLine(TreeConstructor(new string[] { "(1,2)", "(2,4)", "(5,7)", "(7,2)", "(9,5)" }));
            Console.WriteLine(TreeConstructor(new string[] { "(1,2)", "(3,2)", "(2,12)", "(5,2)" }));
        }
    }
}
