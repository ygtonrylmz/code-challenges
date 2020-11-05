using System;
using System.Collections.Generic;
using System.Text;

namespace StringMatching
{
    internal class RabinKarp
    {
        // d is the number of characters in the input alphabet  
        internal readonly static int d = 256;

        internal static void Matcher(string Text, string Pattern, int q)
        {
            int t_length = Text.Length;
            int p_length = Pattern.Length;

            // high order digit position
            var h = Math.Pow(d, (p_length - 1)) % q;
            // hash value for pattern
            int p = 0;
            // hash value for text
            int t0 = 0;

            for (int i = 0; i < p_length; i++)
            {
                p = (d * p + Pattern[i]) % q;
                t0 = (d * t0 + Text[i]) % q;
            }

            for (int s = 0; s < t_length - p_length; s++)
            {
                if (p == t0)
                    if (Pattern[0..p_length] == Text[s..(s + p_length)])
                        Console.WriteLine("Found at index " + s);
                if (s < t_length - p_length)
                {
                    t0 = (int)((d * (t0 - Text[s] * h) + Text[s + p_length]) % q);

                    // We might get negative value of t, converting it  
                    // to positive  
                    if (t0 < 0)
                        t0 = (t0 + q);
                }
            }
        }
    }
}
