using System;
using System.Collections.Generic;
using System.Text;

namespace StringMatching
{
    internal class KMPMatcher
    {
        private static void ComputePrefixFuntion(string Pattern, int p_length, ref int[] lps)
        {
            lps[0] = 0;
            var len = 0;
            for(int i = 1; i< p_length; i++)
            {
                while (len > 0 && Pattern[len + 1] != Pattern[i])
                    len = lps[len];
                if (Pattern[len + 1] == Pattern[i])
                    len += 1;
                lps[i] = len;
            }
        }

        internal static void Matcher(string Text, string Pattern)
        {
            var t_length = Text.Length;
            var p_length = Pattern.Length;

            int[] lps = new int[p_length];

            ComputePrefixFuntion(Pattern, p_length, ref lps);
            var j = 0; // index for pattern
            var i = 0; // index for text
            while (i < t_length)
            {
                if (Pattern[j] == Text[i])
                {
                    j++;
                    i++;
                }
                if (j == p_length)
                {
                    Console.WriteLine("Found pattern "
                                  + "at index " + (i - j));
                    j = lps[j - 1];
                }

                // mismatch after j matches 
                else if (i < t_length && Pattern[j] != Text[i])
                {
                    // Do not match lps[0..lps[j-1]] characters, 
                    // they will match anyway 
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i = i + 1;
                }
            }
        }
    }
}
