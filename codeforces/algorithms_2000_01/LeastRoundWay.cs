// https://codeforces.com/problemset/problem/2/B
using System;
using System.Linq;

namespace algorithms_2000_01
{
    class LeastRoundWay
    {
        public void Solve()
        {
            var grid = ReadMatrix();
            var dp2 = GetDPMatrixForFactor(grid, 2);
            var dp5 = GetDPMatrixForFactor(grid, 5);
            PrintAnswer(grid, dp2, dp5);
        }

        private void PrintAnswer(int[,] grid, int[,] dp2, int[,] dp5)
        {
            var length = dp2.GetLength(0);
            var (hasZero, zeroX, zeroY) = MatrixHasZero(grid);
            var dp = dp2[length - 1, length - 1] < dp5[length - 1, length - 1] ? dp2 : dp5;
            if (hasZero && dp[length - 1, length - 1] > 1)
                GoThroughZero(zeroX, zeroY, length);
            else
                WalkthroughMinimumRoad(dp);
        }

        private void WalkthroughMinimumRoad(int[,] dp)
        {
            Console.WriteLine(dp[dp.GetLength(0) - 1, dp.GetLength(0) - 1]);
            Console.WriteLine(PrintRoadWithRecursion(dp, dp.GetLength(0) - 1, dp.GetLength(0) - 1));
        }

        private string PrintRoadWithRecursion(int[,] dp, int i, int j)
        {
            if (i == 0 && j == 0) return "";
            if (i == 0 || (j != 0 && dp[i, j - 1] < dp[i - 1, j]))
                return PrintRoadWithRecursion(dp, i, j - 1) + "R";
            return PrintRoadWithRecursion(dp, i - 1, j) + "D";
        }

        private void GoThroughZero(int zeroX, int zeroY, int length)
        {
            Console.WriteLine(1);
            var road = string.Join("", new int[zeroX].Select(x => "D"))
                + string.Join("", new int[zeroY].Select(x => "R"))
                + string.Join("", new int[length - zeroX - 1].Select(x => "D"))
                + string.Join("", new int[length - zeroY - 1].Select(x => "R"));
            Console.WriteLine(road);
        }

        private int[,] GetDPMatrixForFactor(int[,] grid, int factor)
        {
            var length = grid.GetLength(0);
            var dp = new int[length, length];
            dp[0, 0] = GetFactorCount(grid[0, 0], factor);
            for (int i = 1; i < length; i++)
                dp[i, 0] = dp[i - 1, 0] + GetFactorCount(grid[i, 0], factor);
            for (int i = 1; i < length; i++)
                dp[0, i] = dp[0, i - 1] + GetFactorCount(grid[0, i], factor);
            for (int i = 1; i < length; i++)
                for (int j = 1; j < length; j++)
                    dp[i, j] = GetFactorCount(grid[i, j], factor) + Math.Min(dp[i - 1, j], dp[i, j - 1]);
            return dp;
        }

        private int GetFactorCount(int number, int factor, int factorCount = 0)
        {
            if (number % factor != 0 || number == 0) return factorCount;
            return GetFactorCount(number / factor, factor, factorCount + 1);
        }

        private int[,] ReadMatrix()
        {
            var length = int.Parse(Console.ReadLine());
            var grid = new int[length, length];
            for (int i = 0; i < length; i++)
            {
                var array = ReadArray();
                for (int j = 0; j < length; j++)
                    grid[i, j] = array[j];
            }
            return grid;
        }

        private (bool, int, int) MatrixHasZero(int[,] grid)
        {
            for (int i = 1; i < grid.GetLength(0); i++)
                for (int j = 1; j < grid.GetLength(0); j++)
                    if (grid[i, j] == 0)
                        return (true, i, j);
            return (false, 0, 0);
        }

        private int[] ReadArray()
        {
            return Console.ReadLine()
                .Split(new char[] { ' ' })
                .Select(x => int.Parse(x))
                .ToArray();
        }
    }
}
