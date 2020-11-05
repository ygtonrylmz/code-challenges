using System;
using System.Collections.Generic;
using System.Text;

namespace StringMatching
{
    internal class Naive
    {
        internal static void NaiveStringMatcher(string T, string P)
        {
            int n = T.Length;
            int m = P.Length;
            for (int s = 0 ; s < n - m; s++)
            {
                if(P[0..m] == T[(s)..(s+m)])
                    Console.WriteLine("Pattern occurs");
            }
        }
    }
}
