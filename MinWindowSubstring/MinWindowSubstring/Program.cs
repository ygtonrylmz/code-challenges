using System;
using System.Collections.Generic;
using System.Linq;

namespace MinWindowSubstring
{
    //    Have the function MinWindowSubstring(strArr) take the array of strings stored in strArr, which will contain only two strings, the first parameter being the string N and the second parameter being a string K of some characters, and your goal is to determine the smallest substring of N that contains all the characters in K.For example: if strArr is ["aaabaaddae", "aed"] then the smallest substring of N that contains the characters a, e, and d is "dae" located at the end of the string. So for this example your program should return the string dae.


    //Another example: if strArr is ["aabdccdbcacd", "aad"] then the smallest substring of N that contains all of the characters in K is "aabd" which is located at the beginning of the string. Both parameters will be strings ranging in length from 1 to 50 characters and all of K's characters will exist somewhere in the string N. Both strings will only contains lowercase alphabetic characters.
    //Examples
    //Input: new string[] {"ahffaksfajeeubsne", "jefaa"}
    //Output: aksfaje
    //Input: new string[] { "aaffhkksemckelloe", "fhea" }
    //Output: affhkkse
    class Program
    {
        public static string MinWindowSubstring(string[] strArr)
        {

            // code goes here 
            var all = strArr[0];
            var searched = strArr[1];
            var dic = new Dictionary<char, int>();

            foreach (var s in searched)
            {
                if (dic.ContainsKey(s))
                    dic[s] = dic[s] + 1;
                else
                    dic[s] = 1;
            }

            for (int i = searched.Length; i <= all.Length; i++)
            {
                for (int j = 0; j < all.Length; j++)
                {
                    if (j + i <= all.Length)
                    {
                        var sub = all.Substring(j, i).ToCharArray();
                        if (dic.Keys.All(key => sub.Count(s => s == key) >= dic[key]))
                        {
                            return new string(sub);
                        }
                    }
                }
            }
            return "";

        }

        static void Main(string[] args)
        {
            Console.WriteLine(MinWindowSubstring(new string[] { "ahffaksfajeeubsne", "jefaa" }));
        }
    }
}
