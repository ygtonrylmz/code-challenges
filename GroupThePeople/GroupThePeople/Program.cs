using System;
using System.Collections;
using System.Collections.Generic;

namespace GroupThePeople
{
    class Program
    {
        public static IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            for (int index = 0; index < groupSizes.Length; index++)
            {
                if (dic.ContainsKey(groupSizes[index]))
                {
                    dic[groupSizes[index]].Add(index);
                }
                else
                {
                    dic.Add(groupSizes[index], new List<int> { index });
                }
            }

            foreach (var (key, value) in dic)
            {
                List<int> temp = new List<int>();
                for(int i = 0; i < value.Count; i++)
                {
                    temp.Add(value[i]);
                    if(temp.Count == key)
                    {
                        result.Add(temp);
                        temp = new List<int>();
                    }
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            GroupThePeople(new int[] { 3, 3, 3, 3, 3, 1, 3 });
        }
    }
}
