// https://codeforces.com/problemset/problem/509/A
using System;

namespace algorithms_700_01
{
    public class MaximumTable
    {
        public void Solve()
        {
            var squareLength = int.Parse(Console.ReadLine());
            var grid = new int[squareLength, squareLength];
            for (int i = 0; i < squareLength; i++)
                for (int j = 0; j < squareLength; j++)
                    grid[i, j] = (i == 0 || j == 0) ? 1 : grid[i, j - 1] + grid[i - 1, j];
            Console.WriteLine(grid[squareLength - 1, squareLength - 1]);
        }
    }
}
