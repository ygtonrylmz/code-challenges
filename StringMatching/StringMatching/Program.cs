using System;

namespace StringMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            var txt = "GEEKS FOR GEEKS";
            var pat = "GEEK";

            // A prime number  
            int q = 101;

            // Function Call 
            //RabinKarp.Matcher(txt, pat, q);

            KMPMatcher.Matcher(txt, pat);
        }
    }
}
