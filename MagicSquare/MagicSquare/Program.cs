using System;

namespace MagicSquare
{
    class Program
    {
        static int FormingMagicSquare(int[,] s)
        {

            int[,,] p =
                {
                        {{8, 1, 6}, {3, 5, 7}, {4, 9, 2}},
                        {{6, 1, 8}, {7, 5, 3}, {2, 9, 4}},
                        {{8, 3, 4}, {1, 5, 9}, {6, 7, 2}},
                        {{6, 7, 2}, {1, 5, 9}, {8, 3, 4}},
                        {{4, 9, 2}, {3, 5, 7}, {8, 1, 6}},
                        {{2, 9, 4}, {7, 5, 3}, {6, 1, 8}},
                        {{2, 7, 6}, {9, 5, 1}, {4, 3, 8}},
                        {{4, 3, 8}, {9, 5, 1}, {2, 7, 6}}
                };

            int min = int.MaxValue;
            for (int i = 0; i < 8; i++)
            {
                int diff = 0;
                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        diff += Math.Abs(p[i, x, y] - s[x, y]);
                    }
                }
                if (diff < min)
                    min = diff;
            }
            return min;
        }
        static void Main(string[] args)
        {
            int[,] arr = { { 5, 3, 4 }, { 1, 5, 8 }, { 6, 4, 2 } };

            Console.WriteLine(FormingMagicSquare(arr));
        }
    }
}
