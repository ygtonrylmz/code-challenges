using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace SherlockValidString
{
    class Program
    {
        //https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem
        static string isValid(string s)
        {
            if (!Regex.IsMatch(s, @"^[a-z]+$")) return "NO";

            var dic = new Dictionary<char, int>();
            foreach (char item in s)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item] += 1;
                }
                else
                {
                    dic[item] = 1;
                }
            }

            int counter = 0;
            bool IsValid = true;
            int firstValue = dic.First().Value;
            foreach (int value in dic.Values)
            {
                if (firstValue != value)
                {
                    if (counter >= 1)
                    {
                        IsValid = false;
                        break;
                    }
                    counter++;
                }
            }
            if (IsValid)
                return "YES";
            else
                return "NO";

        }


        static void Main(string[] args)
        {

            string result = isValid(Console.ReadLine());

            Console.WriteLine(result);
        }
    }
}
