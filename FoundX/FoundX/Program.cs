using System;
using System.Collections.Generic;
using System.Linq;

namespace FoundX
{
    class Program
    {

        public static int GetX(string text)
        {
            var splittedBlank = text.Split(' '); // 3x2 , + , 20 , = , 392
            string ops = "";
            var containsX = splittedBlank.First(w => w.Contains('x'));
            splittedBlank = splittedBlank.Where(w => w != containsX).ToArray();
            var result = 0;
            var isReversedOps = true;
            if (splittedBlank.Last() == "=" || splittedBlank.First() == "=") isReversedOps = false;
            splittedBlank = splittedBlank.Where(w => w != "=").ToArray();
            int[] nums = new int[2];
            var temp = 0;
            foreach (var item in splittedBlank)
            {
                if (item.All(char.IsNumber))
                {
                    nums[temp] = int.Parse(item);
                    temp++;
                }
                else
                    ops = item;

            }

            var calculationResult = GetResult(nums, ops, isReversedOps);

            var xPosition = containsX.IndexOf("x");
            if (containsX.Length > 1)
                result = int.Parse(calculationResult.ToString().ElementAtOrDefault(xPosition).ToString());
            else
                result = calculationResult;
            return result;
        }

        public static int GetResult(int[] nums, string ops, bool isReversedOps)
        {
            switch (ops)
            {
                case "+":
                    return isReversedOps ? nums[1] - nums[0] : nums[1] + nums[0];

                case "-":
                    return isReversedOps ? nums[1] + nums[0] : nums[1] - nums[0];

                case "*":
                    return isReversedOps ? nums[0] == 0 ? 0 : nums[1] / nums[0] : nums[1] * nums[0];
                case "/":
                    return isReversedOps ? nums[0] * nums[1] : nums[0] == 0 ? 0 : nums[1] / nums[0];
                default:
                    return 0;
            }
        }
        static void Main(string[] args)
        {
            string text = "17 * x42 = 5814";
            var result = GetX(text);
            Console.WriteLine($"x = {result}");
        }
    }
}
;