using System;
using System.Collections.Generic;
using System.Linq;

namespace ClimbingTheLeaderboard
{
    class Program
    {
        //https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem

        public static Dictionary<int, int> ArrangeRankedList(List<int> ranked)
        {
            var max = int.MinValue;
            var position = 1;
            var dic = new Dictionary<int, int>();
            foreach (var item in ranked)
            {
                if (item > max)
                {
                    if (!dic.ContainsKey(item))
                    {
                        dic.Add(item, position);
                        position++;
                    }
                }
            }
            return dic;
        }

        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            var rankedList = ArrangeRankedList(ranked);

            return ArrangePlayerList(rankedList, player);

        }

        private static List<int> ArrangePlayerList(Dictionary<int, int> rankedList, List<int> player)
        {
            List<int> result = new List<int>();
            foreach (var item in player)
            {
                var added = false;
                foreach (KeyValuePair<int, int> keyValuePair in rankedList)
                {
                    if (item >= keyValuePair.Key)
                    {
                        result.Add(keyValuePair.Value);
                        added = true;
                        break;
                    }
                }
                if (!added)
                {
                    result.Add(rankedList.Last().Value + 1);
                }

            }
            return result;
        }

        static void Main(string[] args)
        {
            // Brutte Force
            //var result = climbingLeaderboard(new List<int> { 100, 90, 90, 80 }, new List<int> { 70, 80, 105 });
            //Console.WriteLine(String.Join("\n", result));

            // Binary Search
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> rankedList = Console.ReadLine().Split(' ').Distinct().Select(x => int.Parse(x)).ToList();
            int m = Convert.ToInt32(Console.ReadLine());
            List<int> playerList = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

            rankedList.Reverse();

            int bs;
            for (int i = 0; i < m; i++)
            {
                bs = rankedList.BinarySearch(playerList[i]);
                if (bs >= 0)
                    Console.WriteLine(rankedList.Count - bs);
                else
                    Console.WriteLine(rankedList.Count + 2 + bs);
            }
        }
    }
}
