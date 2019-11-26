// https://codeforces.com/problemset/problem/263/A
using System;

namespace algorithms_700_01
{
    public class BeautifulMatrix
    {
        public void ParseSolveWrite()
        {
            var grid = Parse();
            var minimumShifts = Solve(grid);
            Write(minimumShifts);
        }

        private void Write(int minimumShifts)
        {
            Console.WriteLine(minimumShifts);
        }

        private int Solve(int[,] grid)
        {
            int x = 0, y = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        x = i;
                        y = j;
                    }
                }
            }
            return Math.Abs(x - 2) + Math.Abs(y - 2);
        }

        private int[,] Parse()
        {
            var grid = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                var input = Console.ReadLine();
                for (int j = 0; j < 5; j++)
                    grid[i, j] = int.Parse(input.Substring(2 * j, 1));
            }
            return grid;
        }
    }


}
